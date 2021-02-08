using System;
using System.Collections.Generic;
using System.Text;

using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
   public interface ICarService
    {
      
        Car GetCarById(int id);
       
        List<Car> GetByCarsColorId(int id);

        void Add(Car car);

        List<Car> GetCarsByBrandId(int id);

        List<CarDetailDto> GetCarProperties();
        

        

    }
}
