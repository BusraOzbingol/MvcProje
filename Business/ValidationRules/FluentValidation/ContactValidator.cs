using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ContactValidator: AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(p => p.ContactId).NotEmpty();
            RuleFor(p => p.UserName).MaximumLength(50);
            RuleFor(p => p.UserMail).MaximumLength(50);
            RuleFor(p => p.Subject).MaximumLength(50);
        }
    }
}
