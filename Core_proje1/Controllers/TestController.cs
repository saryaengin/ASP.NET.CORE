using Microsoft.AspNetCore.Mvc;

namespace Core_proje1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
