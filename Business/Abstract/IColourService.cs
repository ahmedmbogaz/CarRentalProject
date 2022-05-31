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
        List<Colour> GetAll();
        List<Colour> GetCarsByBrandId(int id);
        List<Colour> GetCarsByColourId(int id);
        List<Colour> GetByUnitPrice(int min, int max);
        List<CarDetailDto> GetByCarDetails(); // bu lazım mı ?
    }
}
