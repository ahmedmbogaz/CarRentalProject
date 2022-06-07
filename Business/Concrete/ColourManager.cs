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
    public class ColourManager : IColourService
    {
        IColourDal _colourDal;

        public ColourManager(IColourDal colourDal)
        {
            _colourDal = colourDal;
        }
        public IResult Add(Colour colour)
        {
            _colourDal.Add(colour);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Colour colour)
        {
            _colourDal.Delete(colour);
            return new SuccessResult(Messages.CarDelete);
        }

        public IDataResult<List<Colour>> GetAll()
        {
            return new SuccessDataResult<List<Colour>>(_colourDal.GetAll());
        }

        public IResult Update(Colour colour)
        {
            _colourDal.Update(colour);
            return new SuccessResult(Messages.CarUpdate);
        }
    }
}
