using System;

using Business.Concrete;

using DataAccess.Concrete.InMemory;

namespace CarProjectUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            ColorManager colorManager = new ColorManager(new InMemoryColorDal());
            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());

            var WhichIdOfCar = 1;
            foreach (var car in carManager.GetById(WhichIdOfCar) )
            {
                var carColor = car.ColorId;
                var carBrand = car.BrandId;
                
                
                foreach (var color in colorManager.GetById(carColor))
                {
                    Console.WriteLine(color.ColorName);
                }
                foreach (var brand in brandManager.GetById(carBrand))
                {
                    Console.WriteLine(brand.BrandName);

                }
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.ModelYear);
                

            }
            
             
            
        }
        
}
}
