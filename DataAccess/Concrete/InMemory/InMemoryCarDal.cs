using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>() { 
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear="2021",DaliyPrice=200_000,Description="Yol tutuşu İyidir."},
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear="2020",DaliyPrice=500_000,Description="Yol tutuşu İyidir. Boyasız"},
                new Car{Id=3,BrandId=2,ColorId=3,ModelYear="2019",DaliyPrice=700_000,Description="Yol tutuşu İyidir. Boyasız"},
                new Car{Id=4,BrandId=2,ColorId=3,ModelYear="2018",DaliyPrice=300_000,Description="Yol tutuşu İyidir. Boyasız"},
                new Car{Id=5,BrandId=2,ColorId=2,ModelYear="2020",DaliyPrice=400_000,Description="Yol tutuşu İyidir. Boyasız"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = new();
            carToDelete=_cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetByCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(Car car)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = new();
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DaliyPrice = car.DaliyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
