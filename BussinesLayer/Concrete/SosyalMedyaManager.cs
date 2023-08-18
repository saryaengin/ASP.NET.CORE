using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLayer.Abstract;
using BussinesLayer.Abtract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BussinesLayer.Concrete
{
    public class SosyalMedyaManager : ISosyalMedyaService
    {
        ISosyalMedyaDal _sosyalMedyaDal;

        public SosyalMedyaManager(ISosyalMedyaDal sosyalMedyaDal)
        {
            _sosyalMedyaDal = sosyalMedyaDal;
        }

        public void TAdd(SosyalMedya t)
        {
           _sosyalMedyaDal.Insert(t);
        }

        public void TDelete(SosyalMedya t)
        {
            _sosyalMedyaDal.Delete(t);
        }

        public SosyalMedya TGetByID(int id)
        {
            return _sosyalMedyaDal.GetByID(id);
        }

        public List<SosyalMedya> TGetList()
        {
            return _sosyalMedyaDal.GetList();
        }

        public List<SosyalMedya> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SosyalMedya t)
        {
            _sosyalMedyaDal.Update(t);
        }
    }
}
