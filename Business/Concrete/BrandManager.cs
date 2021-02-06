using System;
using System.Collections.Generic;
using System.Text;

using Business.Abstract;

using DataAccess.Abstract;

using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public Brand GetByBrandId(int id)
        {
            return _brandDal.Get(p => p.Id == id);
        }
    }
}
