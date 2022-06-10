using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    //DTO larda işlem yapmak
    public class CarValidator : AbstractValidator<Car>//doğrulama kuralları 
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.DaliyPrice).NotEmpty();
            RuleFor(c => c.DaliyPrice).GreaterThan(0);
            RuleFor(c => c.Description).MaximumLength(700);
        }
    }
}
