using BusinessLayer.Concrete;
using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_proje1.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
	     MessageManager messageManager = new MessageManager(new EfMessageDal());
       public IViewComponentResult Invoke()
       {
	       var values = messageManager.TGetList().Take(4).ToList();
	       return View(values);
       }
    }
}
