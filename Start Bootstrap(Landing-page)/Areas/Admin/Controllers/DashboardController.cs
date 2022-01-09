using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Start_Bootstrap_Landing_page_.DAL;
using Start_Bootstrap_Landing_page_.Models;
using Start_Bootstrap_Landing_page_.Utilities;
using Start_Bootstrap_Landing_page_.ViewModels;
using Start_Bootstrap_Landing_page_.ViewModels.Dashboard;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Start_Bootstrap_Landing_page_.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private AppDbContext _context;
        private IWebHostEnvironment _env;

        public DashboardController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Informations = await _context.Informations
                                           .Where(i => i.IsDeleted == false)
                                           .ToListAsync(),
            };
            return View(homeVM);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateVM createVM)
        {
            if (!ModelState.IsValid) return View(createVM);
            bool isExist = _context.Informations.Any(i => i.Head.Trim()
                                                            .ToLower() == createVM.Head.Trim().ToLower());
            if (isExist)
            {
                ModelState.AddModelError("Head", "Multiple Name");
                return View(createVM);
            }
            if (createVM.Photo.Length / 1024 > 200)
            {
                ModelState.AddModelError("Photo", $"The file is larger than {200}");
                return View(createVM);
            }
            if (!createVM.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", $"The file type is not valid");
                return View(createVM);
            }
            var fileName = Guid.NewGuid().ToString() + "_" + createVM.Photo.FileName;
            string rootPath = Path.Combine(_env.WebRootPath, "assets/img", fileName);
            using (FileStream fileStream = new FileStream(rootPath, FileMode.Create))
            {
                await createVM.Photo.CopyToAsync(fileStream);
            }
            Information information = new Information
            {
                Head = createVM.Head,
                Content = createVM.Content,
                Image = fileName
            };
            await _context.Informations.AddAsync(information);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int id)
        {
            Information information = _context.Informations.Find(id);
            if (information == null) return NotFound();
            return View(information);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Information update)
        {
            if (id != update.Id) return BadRequest();

            if (!ModelState.IsValid) return View(update);
            Information dbInformation = await _context.Informations.Where(i => i.IsDeleted == false &&  i.Id == id).FirstOrDefaultAsync();

            if (dbInformation.Head.Trim().ToLower()!=update.Head.Trim().ToLower())
            {
                dbInformation.Head = update.Head;
            }
            
            if (update.Photo.Length / 1024 > 200)
            {
                ModelState.AddModelError("Photo", $"The file is larger than {200}");
                return View(update);
            }
            if (!update.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", $"The file type is not valid");
                return View(update);
            }
            Helper.RemoveFile(_env.WebRootPath, "img", dbInformation.Image);
            var fileName = Guid.NewGuid().ToString() + "_" + update.Photo.FileName;
            string rootPath = Path.Combine(_env.WebRootPath, "assets/img", fileName);
            using (FileStream fileStream = new FileStream(rootPath, FileMode.Create))
            {
                await update.Photo.CopyToAsync(fileStream);
            }
            dbInformation.Content = update.Content;
            dbInformation.Image = fileName;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Information dbInformation = await _context.Informations.Where(i => i.IsDeleted == false && i.Id == id)  
                                                                                                    .FirstOrDefaultAsync();
            if (dbInformation == null) return View();
            dbInformation.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
