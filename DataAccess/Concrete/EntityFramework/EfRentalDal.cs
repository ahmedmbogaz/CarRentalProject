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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<RentalDetailDto> GetByRentalDetails()
        {
            using (CarRentalContext context = new())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join u in context.Customers
                             on r.CustomerId equals u.Id
                             
                             join us in context.Users
                             on u.UserId equals us.Id
                             select new RentalDetailDto
                             {
                                 Id=r.Id,
                                 UserName=$"{us.FirstName} {us.LastName}",  //us.FirstName + " "+us.LastName,
                                 CompanyName =u.CompanyName,
                                 CarName=c.CarName,
                                 ReturnDate=(DateTime)r.ReturnDate,
                                 RentDate=r.RentDate
                             };
                return result.ToList();
            }
        }
    }
}
