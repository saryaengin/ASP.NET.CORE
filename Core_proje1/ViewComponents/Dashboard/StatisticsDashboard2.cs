using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_proje1.ViewComponents.Dashboard
{
    public class StatisticsDashboard2 : ViewComponent
    {
        private Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.o1 = c.Portfolios.Count();
            ViewBag.o2 = c.Messages.Count();
            ViewBag.o3 = c.Testimonials.Count();
            return View();
        }
    }
}