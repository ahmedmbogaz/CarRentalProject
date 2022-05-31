using Business.Abstract;
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

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetByCarDetails()
        {
            return _carDal.GetByCarDetails();
        }

        public List<Car> GetByUnitPrice(int min, int max)
        {
            return _carDal.GetAll(p=>p.DaliyPrice>=min && p.DaliyPrice<=max);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p=>p.BrandId==id); // brandId benim gönderdiğim ID ye eşit ise onları filtrele demek
        }

        public List<Car> GetCarsByColourId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }
    }
}
