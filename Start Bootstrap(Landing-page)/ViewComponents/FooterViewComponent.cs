using Microsoft.AspNetCore.Mvc;

namespace Start_Bootstrap_Landing_page_.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
