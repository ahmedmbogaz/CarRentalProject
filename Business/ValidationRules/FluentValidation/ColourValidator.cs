using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ColourValidator:AbstractValidator<Colour>
    {
        public ColourValidator()
        {
            RuleFor(c => c.ColourName).NotEmpty();
            RuleFor(c => c.ColourName).MinimumLength(2);
        }
    }
}
