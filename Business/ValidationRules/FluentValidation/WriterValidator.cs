using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(p => p.WriterId).NotEmpty();
            RuleFor(p => p.WriterName).MaximumLength(50);
            RuleFor(p => p.WriterSurName).MaximumLength(50);
            RuleFor(p => p.WriterImage).MaximumLength(100);
            RuleFor(p => p.WriterMail).MaximumLength(50);
            RuleFor(p => p.WriterPassword).MaximumLength(20);
        }
    }
}
