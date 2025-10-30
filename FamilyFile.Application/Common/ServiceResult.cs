using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Application.Common
{
    public class ServiceResult<T>
    {
        public bool IsSuccess { get; set; }
        public Guid Id { get; set; }
        public T Data { get; set; }
        public List<string> Errors { get; set; }
        public string Msg { get; set; }
        public static ServiceResult<T> Result(T data, List<string> errors, string msg)
        {
            return new ServiceResult<T>() { Data = data, Errors = errors, Msg = msg };
        }
    }
}
