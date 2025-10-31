using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Domain.Entities
{
    public class Personnel: BaseEntitie
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(10)]
        public string NationalCode { get; set; }

        [Required]
        [MaxLength(12)]
        public string PhoneNumber { get; set; }
    }
}
