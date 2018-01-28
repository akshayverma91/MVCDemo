using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Validation
{
    public class FirstNameValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value == null)  //Check for Mull Value
            {
                return new ValidationResult("Please Provide First Name");
            }
            else
            {
                if(value.ToString().Contains('@'))
                {
                    return new ValidationResult("Should not contain any @ symbols!");
                }
            }
            return ValidationResult.Success;
        }
    }
}