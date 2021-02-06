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
    public class EfColorDal : IColorDal
    {
        GalleryContext _context = new GalleryContext();
        public void Add(Color entity)
        {
            using (_context)
            {
                var addedColor = _context.Entry(entity);
                addedColor.State = EntityState.Added;
                _context.SaveChanges();

            }
        }

        public void Delete(Color entity)
        {
            using (_context)
            {
                var deletedColor = _context.Entry(entity);
                deletedColor.State = EntityState.Deleted;
                _context.SaveChanges();

            }
        }

        public Color Get(Expression<Func<Color, bool>> predicate)
        {
            using (_context)
            {
                
                return _context.Set<Color>().SingleOrDefault(predicate);
            }
        }
        

        public List<Color> GetAll(Expression<Func<Color, bool>> predicate = null)
        {
            using (_context)
            {
                return predicate == null
                                ? _context.Set<Color>().ToList()
                                : _context.Set<Color>().Where(predicate).ToList();
            }
            

        }

        public void Update(Color entity)
        {
            using (_context)
            {
                var updatedColor = _context.Entry(entity);
                updatedColor.State = EntityState.Modified;
                _context.SaveChanges();

            }
        }
    }
}
