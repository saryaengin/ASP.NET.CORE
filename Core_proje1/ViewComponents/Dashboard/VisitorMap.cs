using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_proje1.ViewComponents.Dashboard
{
    public class VisitorMap : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
