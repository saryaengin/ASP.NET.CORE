using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_proje1.Areas.Writer.ViewComponents
{
    public class Notification : ViewComponent
    {
        private AnnouncementManager announcement = new AnnouncementManager(new EfAnnouncementDal());
        public IViewComponentResult Invoke()
        {
            var values = announcement.TGetList();
            return View(values);
        }
    }
}
