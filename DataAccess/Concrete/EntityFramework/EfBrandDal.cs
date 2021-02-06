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
    public class EfBrandDal : IBrandDal
    {
        GalleryContext _context = new GalleryContext();
        public void Add(Brand entity)
        {
            using (_context)
            {
                var addedBrand = _context.Entry(entity);
                addedBrand.State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (_context)
            {
                var deletedBrand = _context.Entry(entity);
                deletedBrand.State = EntityState.Deleted;
                _context.SaveChanges();

            }
        }

        public Brand Get(Expression<Func<Brand, bool>> predicate)
        {
            using (_context)
            {
                return _context.Set<Brand>().SingleOrDefault(predicate);
            }

            
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> predicate = null)
        {
            using (_context)
            {
                return predicate == null
              ? _context.Set<Brand>().ToList()
              : _context.Set<Brand>().Where(predicate).ToList();
            }
            
        }

        public void Update(Brand entity)
        {
            using (_context)
            {
                var updatedBrand = _context.Entry(entity);
                updatedBrand.State = EntityState.Modified;
                _context.SaveChanges();

            }
        }
    }
}
