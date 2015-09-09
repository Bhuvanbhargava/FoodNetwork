using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http.ExceptionHandling;

namespace FoodNetwork.WebApi.Common
{
    public class WebApiExceptionHandler : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            var request = context.ExceptionContext.Request;
            var content = "Oops! Sorry! Something went wrong." +
                          "Please contact support@contoso.com so we can try to fix it.";
            context.Result = new WebApiHttpActionResult(HttpStatusCode.InternalServerError,content,request );
        }

    }
}