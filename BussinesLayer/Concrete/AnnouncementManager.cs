﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BussinesLayer.Concrete
{
	public class AnnouncementManager : IAnnouncementService
	{
		private IAnnouncementDal _announcementDal;

		public AnnouncementManager(IAnnouncementDal announcementDal)
		{
			_announcementDal = announcementDal;
		}

		public void TAdd(Announcement t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Announcement t)
		{
			throw new NotImplementedException();
		}

		public Announcement TGetByID(int id)
		{
			return _announcementDal.GetByID(id);
		}

        public List<Announcement> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public List<Announcement> TGetList()
		{
			return _announcementDal.GetList();
		}

		public void TUpdate(Announcement t)
		{
			throw new NotImplementedException();
		}
	}
}