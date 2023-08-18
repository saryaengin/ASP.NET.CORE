using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_proje1.ViewComponents.About
{
	public class AboutList : ViewComponent
	{
		 AboutManager aboutManager = new AboutManager(new EfAboutDal());
		public IViewComponentResult Invoke()
		{
			var values = aboutManager.TGetList();
			return View(values);
		}
	}
}
