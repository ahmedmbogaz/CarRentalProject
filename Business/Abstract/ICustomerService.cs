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
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetCarsByBrandId(int id);
        IDataResult<List<Customer>> GetCarsByColourId(int id);
        IDataResult<List<Customer>> GetByUnitPrice(int min, int max);
        IDataResult<List<CustomerDetailDto>> GetByCarDetails();
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
    }
}
