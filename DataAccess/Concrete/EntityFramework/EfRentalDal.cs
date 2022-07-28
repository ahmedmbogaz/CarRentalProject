using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, EfCarRentalContext>, IRentalDal
    {
        public List<RentalDetailDto> GetByRentalDetails()
        {
            using (EfCarRentalContext context = new())
            {
                var result = from ca in context.Cars
                             join b in context.Brands
                             on ca.BrandId equals b.Id
                             join re in context.Rentals
                             on ca.Id equals re.CarId
                             join co in context.Colours
                             on ca.ColorId equals co.Id

                             from u in context.Users
                             join cu in context.Customers
                             on u.Id equals cu.UserId
                             select new RentalDetailDto
                             {
                                 UserName = $"{u.FirstName} {u.LastName}",
                                 ColourName = co.ColourName,
                                 BrandName = b.BrandName,
                                 ModelYear = ca.ModelYear,
                                 Description=ca.Description,
                                 DaliyPrice=ca.DaliyPrice,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate,
                             };
                return result.ToList();
            }
        }
    }
}
