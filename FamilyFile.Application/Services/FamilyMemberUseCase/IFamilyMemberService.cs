using FamilyFile.Application.Common;
using FamilyFile.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Application.Services.FamilyMemberUseCase
{
    public interface IFamilyMemberService
    {
        ServiceResult<FamilyMemberData> SaveFamilyMember(FamilyMemberData familyMemberData);
        ServiceResult<FamilyMemberData> DeleteFamilyMember(Guid id);
        ServiceResult<List<FamilyMemberData>> GetAllFamilyMember(Guid id);
        ServiceResult<FamilyMemberData> GetFamilyMember(Guid id);
    }
}
