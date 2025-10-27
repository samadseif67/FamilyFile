using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Application.Dto
{
    public class BaseData
    {        
        public Guid Id { get; set; }         
        public int Code { get; set; }
    }
}
