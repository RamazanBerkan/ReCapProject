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
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("Cars Detail Show");
            var n = 1;
            // AddTest(carManager);
            foreach (var car in carManager.GetCarProperties())
            {
               
                Console.WriteLine("{0}. Araba",n);
                Console.WriteLine(car.Name+ "\n" +car.BrandName + "\n" + car.ColorName);
                Console.WriteLine(car.DailyPrice);
                n = n + 1;
            }
            
            Console.WriteLine();


            








        }

        private static void AddTest(CarManager carManager)
        {
            Car car = new Car() { Name = "X", DailyPrice = 0, BrandId = 2, ColorId = 1, Description = "NEW CAR", ModelYear = 2021 };
            carManager.Add(car);
        }
    }
        
}
