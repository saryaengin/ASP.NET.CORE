using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_proje1.Controllers
{
	[Authorize(Roles = "Admin")]
	public class SosyalMedyaController : Controller
    {
        SosyalMedyaManager sosyalMedyaManager = new SosyalMedyaManager(new EfSosyalMedyaDal());

        public IActionResult Index()
        {
            var values = sosyalMedyaManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSocialMedia(SosyalMedya p)
        {
            p.Status = true;
            sosyalMedyaManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSocialMedia(int id)
        {
            var values = sosyalMedyaManager.TGetByID(id);
            sosyalMedyaManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSocialMedia(int id)
        {
            var values = sosyalMedyaManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSocialMedia(SosyalMedya p)
        {
            sosyalMedyaManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
