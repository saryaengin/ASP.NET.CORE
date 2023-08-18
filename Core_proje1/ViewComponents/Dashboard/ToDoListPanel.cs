using BusinessLayer.Concrete;
using BussinesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.EntityFramework;

namespace Core_proje1.ViewComponents.Dashboard
{
	public class ToDoListPanel : ViewComponent
	{
		 ToDoListPanelManager toDoListPanelManager = new ToDoListPanelManager(new EfToDoListPanelDal());

		 public IViewComponentResult Invoke()
		 {
			 var values = toDoListPanelManager.TGetList();
			 return View(values);
		 }
	}
}
