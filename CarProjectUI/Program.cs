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
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            
           

            //ARAÇ EKLEME
            /*
            Car car = new Car() { Name = "X", DailyPrice = 0, BrandId = 2, ColorId = 1, Description = "NEW CAR", ModelYear = 2021 };
            carManager.Add(car);*/


            // Bu bölüm marka id sine göre  araba getirir
           
            var WhicIdGetCarByBrand = 2;
            Console.WriteLine("It is");
            Console.WriteLine(brandManager.GetByBrandId(WhicIdGetCarByBrand).BrandName);
            Console.WriteLine("******");
            //Console.WriteLine(colorManager.GetClor(1).ColorName);
            
            foreach (var item in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine("Color Id");
                Console.WriteLine(item.ColorId);
                /* Bu bölümü düzgün çalıştıramadığım için comment yaptı yardımcı olabilir misiniz?
                Console.WriteLine("Color Name");
                Console.WriteLine(colorManager.GetClor(item.ColorId).ColorName);
                */
               
                Console.WriteLine("Car id");
                Console.WriteLine(item.Id);
                Console.WriteLine("******");
                
                
            }


            
             // Bu bölüm renge göre araba getirir

             var WhicIdGetCarByColor = 2;
             Console.WriteLine("It is");
             Console.WriteLine(colorManager.GetClor(WhicIdGetCarByColor).ColorName);
             Console.WriteLine("******");

             foreach (var item in carManager.GetByCarsColorId(2))
             {
                /* Bu bölümü düzgün çalıştıramadığım için comment yaptı yardımcı olabilir misiniz?
                 Console.WriteLine("Brand Name");
                 Console.WriteLine(brandManager.GetByBrandId(item.BrandId).BrandName);
                */
                 Console.WriteLine("Car id");
                 Console.WriteLine(item.Id);
                 Console.WriteLine("******");
                 //Console.WriteLine("id li arabanın colorid si");
                 //Console.WriteLine(carManager.GetCarById(item.Id).ColorId);

             }
           











        }
    }
        
}
