using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_proje1.ViewComponents.SosyalMedya
{
    public class SosyalMedyaList : ViewComponent
    {
         SosyalMedyaManager sosyalMedya = new SosyalMedyaManager(new EfSosyalMedyaDal());
        public IViewComponentResult Invoke()
        {
            var values = sosyalMedya.TGetList();
            return View(values);
        }
    }
}
