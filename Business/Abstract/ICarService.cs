﻿
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>>GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColourId(int id);
        IDataResult<List<Car>> GetByUnitPrice(int min, int max);
        IDataResult<List<CarDetailDto>> GetByCarDetails();
        IResult Add(Car car);
    }
}