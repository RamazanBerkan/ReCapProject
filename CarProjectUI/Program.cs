using System;

using Business.Concrete;

using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

using Entities.Concrete;

namespace CarProjectUI
{
    class Program
    {
        static void Main(string[] args)
        {
            



            //GetByBrandIdTest();
             GetCarDetailTest();
            // AddTest();

        }

        private static void GetByBrandIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Name);

            }
        }

        private static void AddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car() { Name = "X", DailyPrice = 0, BrandId = 2, ColorId = 1, Description = "NEW CAR", ModelYear = 2021 };
            carManager.Add(car);
        }

        private static void GetCarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("Cars Detail Show");
            var n = 1;
            foreach (var car in carManager.GetCarProperties())
            {

                Console.WriteLine("{0}. Araba", n);
                Console.WriteLine(car.Name + "\n" + car.BrandName + "\n" + car.ColorName);
                Console.WriteLine(car.DailyPrice);
                n = n + 1;
            }

            Console.WriteLine();
        }

      
    }
        
}
