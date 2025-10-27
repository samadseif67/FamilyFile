using FamilyFile.Domain.Entities;
using FamilyFile.Domain.Interfaces;
using FamilyFile.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Infrastructure.Repositories
{
    public class FamilyMemberRepository : Repository<FamilyMember>, IFamilyMemberRepository
    {
        public FamilyMemberRepository(FamilyFileContext db):base(db)
        {
                
        }
    }
}
