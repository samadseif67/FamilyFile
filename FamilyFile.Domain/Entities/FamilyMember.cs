using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(10)]
        public string NationalCode { get; set; }

        
        [MaxLength(12)]
        public string? PhoneNumber { get; set; }
    }
}
