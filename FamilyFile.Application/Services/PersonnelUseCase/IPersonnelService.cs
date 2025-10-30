using FamilyFile.Application.Common;
using FamilyFile.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Application.Services.PersonnelUseCase
{
    public interface IPersonnelService
    {
        Task< ServiceResult<PersonnelData>> SavePersonnel(PersonnelData personnelData);
        ServiceResult<PersonnelData> DeletePersonnel(Guid id);
        ServiceResult<List<PersonnelData>> GetAllPersonnel();
        ServiceResult<PersonnelData> GetPersonnel(Guid id);

    }
}
