//using System;
//using API_Test02.Model;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;

//namespace API_Test02.UpdateValidation
//{
//    public class V2ValidationTicket : ActionFilterAttribute
//    {
//        public override void OnActionExecuting(ActionExecutingContext context)
//        {
//            base.OnActionExecuting(context);
//            var ticket = context.ActionArguments["ticket"] as Ticket;
//            if (ticket != null && !string.IsNullOrWhiteSpace(ticket.owner))
//            {
//                bool isValid = true;
//                if (ticket.EnterDate.HasValue == false)
//                {
//                    context.ModelState.AddModelError("EnterDate", "EnterDate Is Requried");
//                    isValid = false;
//                }
//                if (ticket.EnterDate.HasValue &&
//                    ticket.DueDate.HasValue &&
//                    ticket.EnterDate > ticket.DueDate
//                    )
//                {
//                    context.ModelState.AddModelError("DueDate", "DueDate Is Incorrect");
//                    isValid = false;
//                }
//                if (!isValid)
//                {
//                    context.Result = new BadRequestObjectResult(context.ModelState);
//                }
//            }
//        }
//    }
//}
