using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

using DataAccess.Abstract;

using Entities.Concrete;

using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        GalleryContext _context = new GalleryContext();
        public void Add(Car entity)
        {
            using (_context)
            {
                var addedCar = _context.Entry(entity);
                addedCar.State = EntityState.Added;
                _context.SaveChanges();

            }
        }

        public void Delete(Car entity)
        {
            using (_context)
            {
                var deletedCar = _context.Entry(entity);
                deletedCar.State = EntityState.Deleted;
                _context.SaveChanges();

            }
        }

        public Car Get(Expression<Func<Car, bool>> predicate)
        {
            
            return _context.Set<Car>().SingleOrDefault(predicate);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> predicate = null)
        {
            return predicate == null
                ? _context.Set<Car>().ToList()
                : _context.Set<Car>().Where(predicate).ToList();
        }

        public void Update(Car entity)
        {
            using (_context)
            {
                var updatedCar = _context.Entry(entity);
                updatedCar.State = EntityState.Modified;
                _context.SaveChanges();

            }
        }
    }
}
