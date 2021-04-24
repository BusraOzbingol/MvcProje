using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ContentValidator : AbstractValidator<Content>
    {
        public ContentValidator()
        {

            RuleFor(p => p.ContentId).NotEmpty();
            RuleFor(p => p.ContentValue).MaximumLength(1000);

        }
    }
}
