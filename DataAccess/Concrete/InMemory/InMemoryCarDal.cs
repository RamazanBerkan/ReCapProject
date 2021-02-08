using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

using DataAccess.Abstract;

using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=2,ColorId=1,DailyPrice=100,Description="The Most Economic ",ModelYear=2016},
                new Car{Id=2,BrandId=1,ColorId=3,DailyPrice=150,Description="The Most Preferred",ModelYear=2018},
                new Car{Id=3,BrandId=3,ColorId=2,DailyPrice=180,Description="The Most Quality",ModelYear=2021},
                new Car{Id=4,BrandId=2,ColorId=1,DailyPrice=75,Description="The Most Cheap",ModelYear=2011}

                }
            
            
            ;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteToCar =_cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(deleteToCar);
        }

        public Car Get(Expression<Func<Car, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByID(int id)
        {

            return _cars.Where(p => p.Id == id).ToList() ;

        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
           Car updateToCar =  _cars.SingleOrDefault(p => p.Id == car.Id);
            updateToCar.BrandId = car.BrandId;
            updateToCar.ColorId = car.ColorId;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.Description = car.Description;
            updateToCar.ModelYear = car.ModelYear;


        }
    }
}
