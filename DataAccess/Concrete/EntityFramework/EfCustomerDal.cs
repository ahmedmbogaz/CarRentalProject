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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarRentalContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetByCarDetails()
        {
            using (CarRentalContext carRentalContext = new())
            {
                var result = from c in carRentalContext.Customers
                             join u in carRentalContext.Users
                             on c.UserId equals u.Id
                             select new CustomerDetailDto
                             {
                                 Id = c.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 CompanyName = c.CompanyName
                             };
                return result.ToList();

            }
        }
    }
}
