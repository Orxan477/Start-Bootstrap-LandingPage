using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Start_Bootstrap_Landing_page_.DAL;
using Start_Bootstrap_Landing_page_.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace Start_Bootstrap_Landing_page_.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
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
    }
}
