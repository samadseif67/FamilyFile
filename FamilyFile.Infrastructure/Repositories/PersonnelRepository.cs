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
    public class PersonnelRepository:Repository<Personnel>, IPersonnelRepository
    {
        public PersonnelRepository(FamilyFileContext db):base(db)
        {
               
        }
         





    }
}
