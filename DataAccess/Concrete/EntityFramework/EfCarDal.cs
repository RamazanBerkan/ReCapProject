using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

using Core.DataAccess.EntityFramework;

using DataAccess.Abstract;

using Entities.Concrete;
using Entities.DTOs;

using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, GalleryContext>, ICarDal
    {
        GalleryContext _context = new GalleryContext();
        public List<CarDetailDto> GetCarDetail()
        {
            var result = from c in _context.Cars
                         join co in _context.Colors
                         on c.ColorId equals co.Id
                         join b in _context.Brands
                         on c.BrandId equals b.Id
                         select new CarDetailDto { Name = c.Name, BrandName = b.BrandName, ColorName = c.Name, DailyPrice = c.DailyPrice };

            return result.ToList();

        }
    }
}
