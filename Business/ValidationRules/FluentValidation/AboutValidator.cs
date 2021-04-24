using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(p => p.AboutId).NotEmpty();
            RuleFor(p => p.AboutDetails1).MaximumLength(500);
            RuleFor(p => p.AboutDetails2).MaximumLength(1000);
            RuleFor(p => p.AboutImage1).MaximumLength(100);
            RuleFor(p => p.AboutImage2).MaximumLength(100);
            
        }

    }
}
