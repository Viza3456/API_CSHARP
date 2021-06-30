//using System;
//using System.ComponentModel.DataAnnotations;
//using API_Test02.Model;

//namespace API_Test02.ModelValidation
//{
//    public class TicketValidation : ValidationAttribute
//    {
//        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
//        {
//            var ticket = validationContext.ObjectInstance as Ticket;
//            if (ticket != null && !string.IsNullOrWhiteSpace(ticket.owner))
//            {
//                if (!ticket.DueDate.HasValue)
//                {
//                    return new ValidationResult("Ticket is not Required Duedate");
//                }
//            }
//            return ValidationResult.Success;
//        }
//    }
//}
