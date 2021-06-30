using System;
using System.ComponentModel.DataAnnotations;
using CoreAPI.Model;

namespace CoreAPI.ValidationAttributes
{
    public class Ticket_ValidationDueDateAfterReportDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket = validationContext.ObjectInstance as Ticket;
            if (!ticket.ValidationDueDateAfterReportDate())
            {
                return new ValidationResult("AfterReportDat is reguired");
            }
            return ValidationResult.Success;
        }
    }
}
