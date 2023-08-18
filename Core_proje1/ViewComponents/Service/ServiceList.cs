using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_proje1.ViewComponents.Service
{
	public class ServiceList : ViewComponent
	{
		 ServiceManager serviceManager = new ServiceManager(new EfServiceDal());

		public IViewComponentResult Invoke()
		{
			var values = serviceManager.TGetList();
			return View(values);
		}
	}
}
