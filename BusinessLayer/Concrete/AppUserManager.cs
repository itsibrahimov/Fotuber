﻿using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void TAdd(AppUser t)
        {
            _appUserDal.Insert(t);
        }

        public void TDelete(AppUser t)
        {
            throw new NotImplementedException();
        }

        public AppUser TGetByID(int id)
        {
            return _appUserDal.GetByID(id);
        }

        public List<AppUser> TGetList()
        {
            return _appUserDal.GetList();
        }

        public void TUpdate(AppUser t)
        {
           _appUserDal.Update(t);
        }
    }
}
