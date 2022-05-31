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
    public class ColourManager : IColourService
    {
        IColourDal _colourDal;

        public ColourManager(IColourDal colourDal)
        {
            _colourDal = colourDal;
        }

        public List<Colour> GetAll()
        {
            return _colourDal.GetAll();
        }

        public List<CarDetailDto> GetByCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Colour> GetByUnitPrice(int min, int max)
        {
            throw new NotImplementedException();
        }

        public List<Colour> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Colour> GetCarsByColourId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
