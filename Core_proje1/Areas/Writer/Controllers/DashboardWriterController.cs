using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Core_proje1.Areas.Writer.Controllers
{
    [Area("Writer")]
	[Route("Writer/DashboardWriter/Index")]
	public class DashboardWriterController : Controller
	{
        private readonly UserManager<WriterUser> _userManager;

        public DashboardWriterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
		{
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + " " + values.Surname;

            //Weather APi
            string api = "4064b391ba1fb7d27c764be1a1e1556f";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=denizli&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            //statistics
            Context c = new Context();
			ViewBag.v1 = c.WriterMessages.Where(x => x.Receiver == values.Email).Count();
			ViewBag.v4 = c.WriterMessages.Where(x => x.Sender == values.Email).Count();
			ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = c.Users.Count();
            return View();
        }
	}
}
//https://api.openweathermap.org/data/2.5/weather?q=denizli&mode=xml&lang=tr&units=metric&appid=4064b391ba1fb7d27c764be1a1e1556f