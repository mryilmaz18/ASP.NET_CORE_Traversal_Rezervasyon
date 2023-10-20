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
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void TAdd(AppKullanici t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(AppKullanici t)
        {
            throw new NotImplementedException();
        }

        public AppKullanici TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppKullanici> TGetList()
        {
            return _appUserDal.GetList();
        }

        public void TUpdate(AppKullanici t)
        {
            throw new NotImplementedException();
        }
    }
}
