using FamilyFile.Application.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Application.Validators
{
    public class FamilyMemberDataValidator:AbstractValidator<FamilyMemberData>
    {
        public FamilyMemberDataValidator()
        {
            RuleFor(x => x.Name).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("نام الزامی می باشد").NotNull().WithMessage("نام الزامی می باشد");
            RuleFor(x => x.LastName).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("نام خانوادگی الزامی می باشد").NotNull().WithMessage("نام خانوادگی الزامی می باشد");
            RuleFor(x => x.NationalCode).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("کد ملی الزامی می باشد").NotNull().WithMessage("کد ملی الزامی می باشد");

        }
    }
}
