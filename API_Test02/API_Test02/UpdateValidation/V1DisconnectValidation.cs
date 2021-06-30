//using System;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;

//namespace API_Test02.UpdateValidation
//{
//    public class V1DisconnectValidation : Attribute, IResourceFilter
//    {
//        public void OnResourceExecuted(ResourceExecutedContext context)
//        {
//            throw new NotImplementedException();
//        }

//        public void OnResourceExecuting(ResourceExecutingContext context)
//        {
//            if (!context.HttpContext.Request.Path.Value.ToLower().Contains("v2"))
//            {
//                context.Result = new BadRequestObjectResult(
//                    new
//                    {
//                        Versionting = new[]
//                        {
//                            "This version API is Close please to use Version2"
//                        }
//                    });
//            }
//        }
//    }
//}
