using System;
using System.Collections.Generic;
using System.Text;

using Business.Abstract;

using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;

using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

       

        public Car GetCarById(int id)
        {
            return _carDal.Get(p => p.Id == id);
        }

        public List<Car> GetByCarsColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public void Add(Car car)
        {

            if (car.Name.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else
            {
                if (car.Name.Length < 2)
                {
                    Console.WriteLine("Cars name is min 2 character");
                }
                if (car.DailyPrice <= 0)
                {
                    Console.WriteLine("Daily Price don't must be 0");
                }
                
            }
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }
        
    }
}
