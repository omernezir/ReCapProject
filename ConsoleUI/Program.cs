using Business.Concrete;
using System;
using DataAccess.Concrete;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Microsoft.Data.SqlClient;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //brandManager.Add(new Brand { Name = "Renault" });
            //colorManager.Add(new Color { Name = "Red" });

            //carManager.Add(new Car {BrandId = 2, ColorId = 1, DailyPrice = 300, ModelYear = 2010, Description = "galeriden" });

            //foreach (var car in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(car.Id);
            //}
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id);
            //}
            //foreach (var car in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(car.Id);
            //}
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id);

            //}



            //Console.WriteLine(brandManager.GetById(1).Name);

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName+" "+car.ColorName+" "+car.DailyPrice);
            }

        }
    }
}
