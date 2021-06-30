using System;
using System.ComponentModel.DataAnnotations;
using CoreAPI.Model;

namespace CoreAPI.ValidationAttributes
{
    public class Ticket_ValidationReportDatePresence : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket = validationContext.ObjectInstance as Ticket;
            if (!ticket.ValidationReportDatePresence())
            {
                return new ValidationResult("ReportDate is reguired");
            }
            return ValidationResult.Success;
        }
    }
}
