﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        
        List<Car> GetCarsByBrandId(int Id);
        List<Car> GetCarsByColorId(int Id);

        Car GetById(int Id);

        

        void Add(Car car);
    }
}
