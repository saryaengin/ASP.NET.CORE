using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_proje1.ViewComponents.Skill
{
	public class SkillList : ViewComponent
	{

		SkillManager skillManager = new SkillManager(new EfSkillDal());

		public IViewComponentResult Invoke()
		{
			var values = skillManager.TGetList();
			return View(values);
		}
	}
}
