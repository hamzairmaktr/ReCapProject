using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.UserId).NotEmpty();
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).MinimumLength(3);
            RuleFor(p => p.FirstName).MaximumLength(20);
            RuleFor(p => p.FirstName).MaximumLength(20);
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.LastName).MinimumLength(3);
            RuleFor(p => p.LastName).MaximumLength(20);
            RuleFor(p => p.Password).NotEmpty();
            RuleFor(p => p.Password).MinimumLength(3);
            RuleFor(p => p.Password).MaximumLength(20);
            RuleFor(p => p.Email).NotEmpty();
            RuleFor(p => p.Email).MinimumLength(7);
            RuleFor(p => p.Email).MaximumLength(25);
        }
    }
}
