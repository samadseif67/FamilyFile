using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Domain.Entities
{
    public interface IBaseEntitie
    {       
        Guid Id { get; set; }     
        int Code { get; set; }
    }

    public class BaseEntitie : IBaseEntitie
    {
        [Key]
        public Guid Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }
    }
}
