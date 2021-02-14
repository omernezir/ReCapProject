using Business.Concrete;
using System;
using DataAccess.Concrete;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
            }
            //carManager.Add(new Car {Id=4, BrandId = 1, ColorId = 1, DailyPrice = 150000, ModelYear = 2014, Description = "sahibinden" });

            foreach (var car in carManager.GetById(3))
            {
                Console.WriteLine(car.Id);
            }

        }
    }
}
