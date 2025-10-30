using FamilyFile.Application.Dto;
using FamilyFile.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Application.Common
{
    public static class ErrorsValidator
    {
        public static List<string> GetErrorsValidator(this FluentValidation.Results.ValidationResult validationResult)
        {
            var errors = new List<string>();
            if (validationResult.Errors.Count() > 0)
            {
                errors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }
             
            return errors;
        }
    }
}
