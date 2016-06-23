using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly2.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if ( customer.MembershipTypeId == (byte)MembershipTypes.Unknown)
                return ValidationResult.Success;
            var age = DateTime.Today.Year - customer.DateOfBirth.Year;
            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Vous devez avoir au moins 18 ans");
        }
    }
}