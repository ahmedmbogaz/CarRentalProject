using Business.Concrete;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using Entities.DTOs;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetByUnitPrice(30000, 400000))
            //{
            //    Console.WriteLine(car.Description);
            //}

            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //foreach (var item in rentalManager.GetAll())
            //{
            //    Console.WriteLine(item.FirstName);
            //}

            //CarManager rentalManager = new CarManager(new EfCarDal());
            //rentalManager.Add(new Car {BrandId=1,CarName="Ferrari",ColorId=1,DaliyPrice=100_000,
            //Description="araba gibi araba",ModelYear="2021"});

            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //rentalManager.Add(
            //    new Rental
            //    {
            //        CarId = 1,
            //        CustomerId = 1,
            //        RentDate = DateTime.Now,
            //        ReturnDate = DateTime.Now.AddDays(2)
            //    });

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            categoryManager.Add(new Category { Name="Otomobil"});

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand
            //{
            //    BrandName = "Kartal"
            //});

            //CarManager carManager = new CarManager(new EfCarDal());

            //var result = carManager.GetCarDetails();


            //foreach (var item in carManager.GetCarDetails().Data)
            //{
            //    Console.WriteLine(item.BrandName + "/" + item.ColourName);
            //}
            //Console.WriteLine("Hello World!");
        }
    }
}
