using Microsoft.AspNetCore.Mvc;

namespace Core_proje1.ViewComponents.Dashboard
{
	public class Last5Projects : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
