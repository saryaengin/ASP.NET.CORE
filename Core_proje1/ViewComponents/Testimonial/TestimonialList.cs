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

namespace Core_proje1.ViewComponents.Testimonial
{
	public class TestimonialList : ViewComponent
	{
		private TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());

		public IViewComponentResult Invoke()
		{
			var values = testimonialManager.TGetList();
			return View(values);
		}
	}
}
