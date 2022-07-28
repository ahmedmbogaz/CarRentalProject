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
    public class EfCarDal : EfEntityRepositoryBase<Car, EfCarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (EfCarRentalContext context=new())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join o in context.Colours
                             on c.ColorId equals o.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 ColorId=o.Id,
                                 BrandId=b.Id,
                                 CarName=c.CarName,
                                 BrandName = b.BrandName,
                                 ColourName = o.ColourName,
                                 ModelYear=c.ModelYear,
                                 DaliyPrice = c.DaliyPrice,
                                 Description=c.Description,
                                 ImagePath = (from m in context.CarImages 
                                              where m.CarId == c.Id 
                                              select m.ImagePath)
                                              .FirstOrDefault()
                             };
                return filter == null
               ? result.ToList()
               : result.Where(filter).ToList();

            }
        }
    }
}
