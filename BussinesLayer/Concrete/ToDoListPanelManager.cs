using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ToDoListPanelManager : IToDoListPanelService
    {
        IToDoListPanelDal _doListPanelDal;

        public ToDoListPanelManager(IToDoListPanelDal toDoListDal)
        {
            _doListPanelDal = toDoListDal;
        }


        public void TAdd(ToDoListPanel t)
        {
            _doListPanelDal.Insert(t);
        }

        public void TDelete(ToDoListPanel t)
        {
            _doListPanelDal.Delete(t);
        }

        public void TUpdate(ToDoListPanel t)
        {
            _doListPanelDal.Update(t);
        }

        public List<ToDoListPanel> TGetList()
        {
            return _doListPanelDal.GetList();
        }

        public ToDoListPanel TGetByID(int id)
        {
            return _doListPanelDal.GetByID(id);
        }

        public List<ToDoListPanel> TGetListByFilter()
        {
            throw new NotImplementedException();
        }
    }
}
