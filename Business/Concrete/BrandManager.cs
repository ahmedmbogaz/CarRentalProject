using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length>3 )
            {
                _brandDal.Add(brand);
            }
            else
            {
                Console.WriteLine("Araba ismi minimum 2 karakter olablir.");
            }
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }
    }
}
