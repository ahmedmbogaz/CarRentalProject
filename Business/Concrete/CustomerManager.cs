using Business.Abstract;
using Business.Constants;
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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            if (customer.CompanyName.Length < 2)
            {
                return new ErrorResult(Messages.CarAdded);
            }
            return new SuccessResult();
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CarDelete);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CustomerDetailDto>> GetByCarDetails()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Customer>> GetByUnitPrice(int min, int max)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Customer>> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Customer>> GetCarsByColourId(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CarUpdate);
        }
    }
}
