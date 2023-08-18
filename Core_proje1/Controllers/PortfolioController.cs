using BusinessLayer.Concrete;
using BussinesLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_proje1.Controllers
{
	[Authorize(Roles = "Admin")]
	public class PortfolioController : Controller
	{
		private PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
		public IActionResult Index()
		{
            var values = portfolioManager.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddPortfolio()
		{
            return View();
		}
		[HttpPost]
		public IActionResult AddPortfolio(Portfolio p)
		{
			PortfolioValidator validations = new PortfolioValidator();
			ValidationResult results = validations.Validate(p);

			if (results.IsValid)
			{
				portfolioManager.TAdd(p);
                return RedirectToAction("Index", "Default");
            }
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}

			return View();
		}
		public IActionResult DeletePortfolio(int id)
		{
			var values = portfolioManager.TGetByID(id);
			portfolioManager.TDelete(values);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult EditPortfolio(int id)
		{
            var values = portfolioManager.TGetByID(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult EditPortfolio(Portfolio portfolio)
		{
			PortfolioValidator validations = new PortfolioValidator();
			ValidationResult results = validations.Validate(portfolio);

			if (results.IsValid)
			{
				portfolioManager.TAdd(portfolio);
                return RedirectToAction("Index", "Default");
            }
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
            return View();
		}
	}
}
