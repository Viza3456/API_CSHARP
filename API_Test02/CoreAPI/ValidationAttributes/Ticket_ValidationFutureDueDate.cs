using System;
using System.ComponentModel.DataAnnotations;
using CoreAPI.Model;

namespace CoreAPI.ValidationAttributes
{
    public class Ticket_ValidationFutureDueDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket = validationContext.ObjectInstance as Ticket;
            if (!ticket.ValidationFutureDueDate())
            {
                return new ValidationResult("DueDate future is required");
            }
            return ValidationResult.Success;
        }
    }
}
