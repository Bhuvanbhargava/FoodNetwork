using FoodNetwork.WebApi.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;

namespace FoodNetwork.WebApi
{
    public class RestfulApiException : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            Dictionary<string,string> message;
            IContentNegotiator  negotiator = GlobalConfiguration.Configuration.Services.GetContentNegotiator();
            var result = negotiator.Negotiate(typeof(Dictionary<string,string>), actionExecutedContext.Request, GlobalConfiguration.Configuration.Formatters);

            if (actionExecutedContext.Exception is ArgumentException || actionExecutedContext.Exception is ValidationException) 
            {
                message = new Dictionary<string,string>()
                {
                    {"code",HttpStatusCode.BadRequest.ToString("D")},
                    {"message",actionExecutedContext.Exception.Message}
                };
                actionExecutedContext.Response = new System.Net.Http.HttpResponseMessage()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Content = new ObjectContent<Dictionary<string, string>>(message, result.Formatter, result.MediaType.MediaType)
                };
            }
            else if (actionExecutedContext.Exception is CustomArgumentException )
            {
                var exception = actionExecutedContext.Exception as CustomArgumentException;
                message = new Dictionary<string, string>()
                {
                    {"code",exception.HResult.ToString("D")},
                    {"message",exception.Message}
                };
                actionExecutedContext.Response = new System.Net.Http.HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)exception.HResult,
                    Content = new ObjectContent<Dictionary<string, string>>(message, result.Formatter, result.MediaType.MediaType)
                };
            }
            else
            {
                
                message = new Dictionary<string, string>()
                {
                    {"code",HttpStatusCode.InternalServerError.ToString("D")},
                    {"message",string.Format("There was an issue processing your request, {0}","Please contact Support at (888)888-888")}
                };
                actionExecutedContext.Response = new System.Net.Http.HttpResponseMessage()
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    Content = new ObjectContent<Dictionary<string, string>>(message, result.Formatter, result.MediaType.MediaType)
                };
            }
        }
    }
}