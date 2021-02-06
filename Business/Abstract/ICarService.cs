using System;
using System.Collections.Generic;
using System.Text;

using Entities.Concrete;

namespace Business.Abstract
{
   public interface ICarService : IEntityService<Car>
    {
      
        Car GetCarById(int id);
       
        List<Car> GetByCarsColorId(int id);

        void Add(Car car);

        List<Car> GetCarsByBrandId(int id);

        

        

    }
}
