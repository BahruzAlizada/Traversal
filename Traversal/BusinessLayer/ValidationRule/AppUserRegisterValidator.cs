using DTOLayer.DTOs.RegisterDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule
{
    public class AppUserRegisterValidator : AbstractValidator<AddRegisterDTOs>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Name can not be null");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname can not be null");
            RuleFor(x => x.Email).EmailAddress().NotEmpty().WithMessage("Email can not be null");
            RuleFor(x => x.Username).NotEmpty().WithMessage("UserName Can not be null");
        }
    }
}
