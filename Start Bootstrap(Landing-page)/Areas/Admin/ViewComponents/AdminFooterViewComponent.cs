using Microsoft.AspNetCore.Mvc;

namespace Start_Bootstrap_Landing_page_.Areas.Admin.ViewComponents
{
    public class AdminFooterViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
