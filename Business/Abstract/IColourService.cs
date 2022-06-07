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
    public interface IColourService
    {
        IDataResult<List<Colour>> GetAll();
        IResult Add(Colour colour);
        IResult Update(Colour colour);
        IResult Delete(Colour colour);
    }
}
