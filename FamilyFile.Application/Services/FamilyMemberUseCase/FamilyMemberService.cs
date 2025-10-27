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
using System.Xml.Linq;

namespace FamilyFile.Application.Services.FamilyMemberUseCase
{
    public class FamilyMemberService : IFamilyMemberService
    {
        private readonly IFamilyMemberRepository _familyMemberRepository;
        public FamilyMemberService(IFamilyMemberRepository familyMemberRepository)
        {
            _familyMemberRepository = familyMemberRepository;
        }
        public ServiceResult<FamilyMemberData> SaveFamilyMember(FamilyMemberData familyMemberData)
        {

            try
            {
                FamilyMember familyMemberRegister = new FamilyMember();
                var familyMember = (FamilyMember)MappingAuto<FamilyMemberData, FamilyMember>.Map(familyMemberData);

                if (familyMember.Id == Guid.Empty)
                {
                    familyMemberRegister = _familyMemberRepository.Add(familyMember);
                    _familyMemberRepository.SaveChanges();
                }
                else
                {
                    familyMemberRegister = _familyMemberRepository.Update(familyMember);
                    _familyMemberRepository.SaveChanges();
                }
                

                var FamilyMemberResonse = (FamilyMemberData)MappingAuto<FamilyMember, FamilyMemberData>.Map(familyMemberRegister);
                return new ServiceResult<FamilyMemberData>() { Data = FamilyMemberResonse, IsSuccess = true, Msg = Errors.Ok.GetDescription() };

            }
            catch (Exception ex)
            {
                return new ServiceResult<FamilyMemberData>() { Data = null, IsSuccess = false, Msg = Errors.Cancell.GetDescription() };
            }


        }

        public ServiceResult<FamilyMemberData> DeleteFamilyMember(Guid id)
        {
            try
            {
                var result = _familyMemberRepository.Delete(id);
                _familyMemberRepository.SaveChanges();
                return new ServiceResult<FamilyMemberData>() { Data = null, IsSuccess = true, Msg = Errors.Ok.GetDescription() };
            }
            catch (Exception)
            {
                return new ServiceResult<FamilyMemberData>() { Data = null, IsSuccess = false, Msg = Errors.Cancell.GetDescription() };
            }
        }

        public ServiceResult<FamilyMemberData> GetFamilyMember(Guid id)
        {
            try
            {
                var findFamilyMember = _familyMemberRepository.Find(id);
                var result= MappingAuto<FamilyMember, FamilyMemberData>.Map(findFamilyMember);
                return new ServiceResult<FamilyMemberData>() { Data = result, IsSuccess = true, Msg = Errors.Ok.GetDescription() };
            }
            catch (Exception)
            {
                return new ServiceResult<FamilyMemberData>() { Data = null, IsSuccess = false, Msg = Errors.Cancell.GetDescription() };
            }
        }

        public ServiceResult<List<FamilyMemberData>> GetAllFamilyMember(Guid id)
        {
            try
            {
                var familyMember = _familyMemberRepository.GetAll().Where(x=>x.PersonnelId==id).ToList();
                var result = MappingAuto<FamilyMember, FamilyMemberData>.MapLst(familyMember);
                return new ServiceResult<List<FamilyMemberData>>() { Data = result, IsSuccess = true, Msg = Errors.Ok.GetDescription() };
            }
            catch (Exception)
            {
                return new ServiceResult<List<FamilyMemberData>>() { Data = null, IsSuccess = false, Msg = Errors.Cancell.GetDescription() };
            }
        }
    }
}
