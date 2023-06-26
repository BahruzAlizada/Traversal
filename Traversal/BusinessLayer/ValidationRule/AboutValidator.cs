using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x=>x.TitleOne).NotEmpty().WithMessage("Title Can not be null");
            RuleFor(x => x.TitleTwo).NotEmpty().WithMessage("Title Can not be null");
            RuleFor(x => x.DescriptionOne).NotEmpty().WithMessage("Description can not be null");
            RuleFor(x => x.DescriptionTwo).NotEmpty().WithMessage("Description can not be null");
        }
    }
}
