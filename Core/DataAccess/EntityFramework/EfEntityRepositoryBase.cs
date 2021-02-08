using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

using Core.Entities;

using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TContext : DbContext, new()
        where TEntity : class, IEntity, new()
    {
        TContext _context = new TContext();
        public void Add(TEntity entity)
        {
            using (_context)
            {
                var addedEntity = _context.Entry(entity);
                addedEntity.State = EntityState.Added;
                _context.SaveChanges();
            }

        }

        public void Delete(TEntity entity)
        {
            using (_context)
            {
                var deletedEntity = _context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                _context.SaveChanges();

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            using (_context)
            {
                return _context.Set<TEntity>().SingleOrDefault(predicate);
            }
            
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null)
        {
            using (_context)
            {
                return predicate == null
                ? _context.Set<TEntity>().ToList()
                : _context.Set<TEntity>().Where(predicate).ToList();
            }
            
        }

        public void Update(TEntity entity)
        {
            using (_context)
            {
                var updatedEntity = _context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                _context.SaveChanges();

            }




        }
    }
}