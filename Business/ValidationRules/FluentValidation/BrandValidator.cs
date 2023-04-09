using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(x => x.BrandName).NotEmpty();
            RuleFor(x => x.BrandName).MinimumLength(2);
            RuleFor(x => x.BrandName).MaximumLength(15);
            RuleFor(x => x.BrandId).NotEmpty();
        }
    }
}
