﻿using Business.Abstract;
using Business.Autofac.BusinessAspects;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        
        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDelete);
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==10)
            {
                return new ErrorDataResult<List<Car>>(Messages.CarNameEror);
            }
            return new SuccessDataResult <List<Car>>( _carDal.GetAll(), Messages.CarAdded);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>> (_carDal.GetCarDetails(),Messages.CarNotAdded);
        }

        public IDataResult<List<Car>> GetByUnitPrice(int min, int max)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(p=>p.DaliyPrice>=min && p.DaliyPrice<=max));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>> (_carDal.GetAll(p=>p.BrandId==id)); // brandId benim gönderdiğim ID ye eşit ise onları filtrele demek
        }

        public IDataResult<List<Car>> GetCarsByColourId(int id)
        {
            return new SuccessDataResult<List<Car>> (_carDal.GetAll(p => p.ColorId == id));
        }

        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdate);
        }


        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            Add(car);
            if (car.DaliyPrice>10)
            {
                throw new Exception("");
            }
            Add(car);
            return null;
        }
    }
}
