using FamilyFile.Domain.Entities;
using FamilyFile.Domain.Interfaces;
using FamilyFile.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Infrastructure.Repositories
{
    public class PersonnelRepository : Repository<Personnel>, IPersonnelRepository
    {
        public PersonnelRepository(FamilyFileContext db) : base(db)
        {

        }
        public async Task<bool> IsExistNationalCode(string nationalCode)
        {
            var result =await _db.Personnels.AnyAsync(x => x.NationalCode == nationalCode);
            return result;
        }





    }
}
