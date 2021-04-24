using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryValidator: AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.CategoryName).MaximumLength(50);
            RuleFor(p => p.CategoryDescription).MaximumLength(200);
        }
    }
}
