﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

using Core.Entities;

namespace Core.DataAccess
{
   public interface IEntityRepository<T> 
        where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> predicate=null);
        T Get(Expression<Func<T,bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
      
    }
}