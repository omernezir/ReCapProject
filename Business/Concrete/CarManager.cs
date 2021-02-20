using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;


        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length<2)
            {
                throw new ArgumentOutOfRangeException("Description length must be at least two characters");
            }
            if (car.DailyPrice<=0)
            {
                throw new ArgumentOutOfRangeException("Daily price must be higher than zero");
            }
            
            _carDal.Add(car);


        }

        public Car GetById(int Id)
        {
            return _carDal.Get(p => p.Id == Id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
           
        }



        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carDal.GetAll(p => p.BrandId == Id);
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _carDal.GetAll(p => p.ColorId == Id);
        }


    }
}
