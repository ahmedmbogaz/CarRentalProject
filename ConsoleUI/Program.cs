using Business.Concrete;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetByUnitPrice(30000,400000))
            //{
            //    Console.WriteLine(car.Description);
            //}

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand 
            //{ 
            //    BrandName="TOGG"
            //});

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetByCarDetails())
            {
                Console.WriteLine(item.BrandName+"/"+ item.ColourName);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
