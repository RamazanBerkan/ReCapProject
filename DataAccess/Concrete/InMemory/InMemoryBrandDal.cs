using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

using DataAccess.Abstract;

using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brand;

        public InMemoryBrandDal()
        {
            _brand =new List<Brand>{ 
                new Brand { Id=1,BrandName="BMW",Description="The most prefered" },
                new Brand { Id=2,BrandName="Fiat",Description="The most speeds" },
                new Brand { Id=3,BrandName="Mercedes",Description="The most Quality" }



            };
        }

        public void Add(Brand brand)
        {
            _brand.Add(brand);
        }

        public void Delete(Brand brand)
        {
          Brand deletedToBrand=   _brand.SingleOrDefault(p => p.Id == brand.Id);
            _brand.Remove(deletedToBrand);
        }

        public Brand Get(Expression<Func<Brand, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            return _brand;
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetById(int id)
        {
            return _brand.Where(p => p.Id == id).ToList();
        }

        public void Update(Brand brand)
        {
            Brand updateToBrand= _brand.SingleOrDefault(p => p.Id == brand.Id);
            updateToBrand.BrandName = brand.BrandName;
            updateToBrand.Description = brand.Description;

        }
    }
}
