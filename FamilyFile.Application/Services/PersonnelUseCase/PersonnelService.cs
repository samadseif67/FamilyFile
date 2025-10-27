using FamilyFile.Application.Common;
using FamilyFile.Application.Dto;
using FamilyFile.Application.Enums;
using FamilyFile.Application.Mapping;
using FamilyFile.Domain.Entities;
using FamilyFile.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Application.Services.PersonnelUseCase
{

    public class PersonnelService : IPersonnelService
    {
        private readonly IPersonnelRepository _PersonnelRepository;
        public PersonnelService(IPersonnelRepository PersonnelRepository)
        {
            _PersonnelRepository = PersonnelRepository;
        }
        public ServiceResult<PersonnelData> SavePersonnel(PersonnelData PersonnelData)
        {

            try
            {
                Personnel PersonnelRegister = new Personnel();
                var Personnel = (Personnel)MappingAuto<PersonnelData, Personnel>.Map(PersonnelData);

                if (Personnel.Id == Guid.Empty)
                {
                    PersonnelRegister = _PersonnelRepository.Add(Personnel);
                    _PersonnelRepository.SaveChanges();
                }
                else
                {
                    PersonnelRegister = _PersonnelRepository.Update(Personnel);
                    _PersonnelRepository.SaveChanges();
                }


                var PersonnelResonse = (PersonnelData)MappingAuto<Personnel, PersonnelData>.Map(PersonnelRegister);
                return new ServiceResult<PersonnelData>() { Data = PersonnelResonse, IsSuccess = true, Msg = Errors.Ok.GetDescription() };

            }
            catch (Exception ex)
            {
                return new ServiceResult<PersonnelData>() { Data = null, IsSuccess = false, Msg = Errors.Cancell.GetDescription() };
            }


        }

        public ServiceResult<PersonnelData> DeletePersonnel(Guid id)
        {
            try
            {
                var result = _PersonnelRepository.Delete(id);
                _PersonnelRepository.SaveChanges();
                return new ServiceResult<PersonnelData>() { Data = null, IsSuccess = true, Msg = Errors.Ok.GetDescription() };
            }
            catch (Exception)
            {
                return new ServiceResult<PersonnelData>() { Data = null, IsSuccess = false, Msg = Errors.Cancell.GetDescription() };
            }
        }

        public ServiceResult<PersonnelData> GetPersonnel(Guid id)
        {
            try
            {
                var findPersonnel = _PersonnelRepository.Find(id);
                var result = MappingAuto<Personnel, PersonnelData>.Map(findPersonnel);
                return new ServiceResult<PersonnelData>() { Data = result, IsSuccess = true, Msg = Errors.Ok.GetDescription() };
            }
            catch (Exception)
            {
                return new ServiceResult<PersonnelData>() { Data = null, IsSuccess = false, Msg = Errors.Cancell.GetDescription() };
            }
        }

        public ServiceResult<List<PersonnelData>> GetAllPersonnel()
        {
            try
            {
                var Personnel = _PersonnelRepository.GetAll();
                var result = MappingAuto<Personnel, PersonnelData>.MapLst(Personnel);
                return new ServiceResult<List<PersonnelData>>() { Data = result, IsSuccess = true, Msg = Errors.Ok.GetDescription() };
            }
            catch (Exception)
            {
                return new ServiceResult<List<PersonnelData>>() { Data = null, IsSuccess = false, Msg = Errors.Cancell.GetDescription() };
            }
        }
    }


}
