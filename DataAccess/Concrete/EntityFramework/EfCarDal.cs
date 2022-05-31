using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetByCarDetails()
        {
            using (CarRentalContext context=new())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join o in context.Colours
                             on c.ColorId equals o.Id

                             select new CarDetailDto
                             {
                                 Id=c.Id,
                                 BrandName=b.BrandName,
                                 ColourName=o.ColourName,
                                 DaliyPrice=c.DaliyPrice
                             };
                return result.ToList();
            }
        }
    }
}
