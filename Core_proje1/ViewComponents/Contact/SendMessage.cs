using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;

namespace Core_proje1.ViewComponents.Contact
{
	public class SendMessage : ViewComponent
	{
		MessageManager messageManager = new MessageManager(new EfMessageDal());

		[HttpGet]
		public IViewComponentResult Invoke()
		{
			return View();
		}

		/* [HttpPost]
		public IViewComponentResult Invoke(Message p)
		{
			p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			p.Status = true;
			messageManager.TAdd(p);
			return View();
		}
		*/
	}
}
