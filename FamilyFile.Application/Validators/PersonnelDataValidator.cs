using FamilyFile.Application.Dto;
using FamilyFile.Domain.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Application.Validators
{
    public class PersonnelDataValidator:AbstractValidator<PersonnelData>
    {
        private readonly IPersonnelRepository _personnelRepository;
        public PersonnelDataValidator(IPersonnelRepository personnelRepository)
        {
            _personnelRepository = personnelRepository;

            RuleFor(x => x.Name).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("نام الزامی می باشد").NotNull().WithMessage("نام الزامی می باشد");
            RuleFor(x => x.LastName).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("نام خانوادگی الزامی می باشد").NotNull().WithMessage("نام خانوادگی الزامی می باشد");
            RuleFor(x => x.NationalCode).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("کد ملی الزامی می باشد").NotNull().WithMessage("کد ملی الزامی می باشد");
            RuleFor(x => x.PhoneNumber).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("شماره تلفن الزامی می باشد").NotNull().WithMessage("شماره تلفن الزامی می باشد");
            RuleFor(x => x).MustAsync(EventNationalCodeUnique).WithMessage("کد ملی مورد نظر تکراری می باشد");
        }

        private async Task<bool> EventNationalCodeUnique(PersonnelData e,CancellationToken token)
        {
            return ! await _personnelRepository.IsExistNationalCode(e.NationalCode,e.Id);
        }
    }
}
