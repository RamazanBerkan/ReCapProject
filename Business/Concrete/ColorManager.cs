using System;
using System.Collections.Generic;
using System.Text;

using Business.Abstract;

using DataAccess.Abstract;

using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public Color GetClor(int id)
        {
            return _colorDal.Get(p => p.Id == id);
        }
        
    }
}
