using System;
using System.ComponentModel.DataAnnotations;
using CoreAPI.Model;

namespace CoreAPI.ValidationAttributes
{
    public class Ticket_ValidationDueDatePresence : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket = validationContext.ObjectInstance as Ticket;
            if (!ticket.ValidationDueDatePresence())
            {
                return new ValidationResult("DueDatePresence is reguired");
            }
            return ValidationResult.Success;
        }
    }
}
