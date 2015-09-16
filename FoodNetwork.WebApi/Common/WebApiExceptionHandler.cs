using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.ExceptionHandling;

namespace FoodNetwork.WebApi.Common
{
    public class WebApiExceptionHandler : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            if (context.Exception is ArgumentException || context.Exception is ValidationException)
            {
                var request = context.ExceptionContext.Request;
                context.Result = new WebApiHttpActionResult(HttpStatusCode.BadRequest, context.Exception.Message, request);               
            }
            else if (context.Exception is CustomArgumentException)
            {             
                var exception = context.Exception as CustomArgumentException;
                var request = context.ExceptionContext.Request;
                var statusCode = (HttpStatusCode)exception.HResult;
                context.Result = new WebApiHttpActionResult(statusCode, exception.Message, request);                  
                
            }
         
        }

    }
}