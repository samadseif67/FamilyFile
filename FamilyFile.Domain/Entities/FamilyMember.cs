using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Domain.Entities
{
    public class FamilyMember: BaseEntitie
    { 
        [ForeignKey(nameof(PersonnelId))]
        public Personnel Personnel { get; set; }
        public Guid PersonnelId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
