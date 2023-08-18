using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Core_proje1.ViewComponents.Contact
{
	public class ContactDetails : ViewComponent
	{
		 ContactManager contactManager = new ContactManager(new EfContactDal());
		public IViewComponentResult Invoke()
		{
			var values = contactManager.TGetList();
			return View(values);
		}
	}
}
