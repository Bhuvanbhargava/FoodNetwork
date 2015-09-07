using FoodNetwork.WebApi.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodNetwork.WebApi.Controllers
{
    public class WebApiController : ApiController
    {
        protected WebApiHttpActionResult Conflict(string message) 
        {
            return new WebApiHttpActionResult(HttpStatusCode.Conflict, message,Request);
        }

        protected WebApiHttpActionResult NotFound(string message)
        {
            return new WebApiHttpActionResult(HttpStatusCode.NotFound, message, Request);
        }

        protected WebApiHttpActionResult Unauthorized(string message)
        {
            return new WebApiHttpActionResult(HttpStatusCode.Unauthorized, message, Request);
        }

        protected WebApiHttpActionResult MethodNotAllowed(string message)
        {
            return new WebApiHttpActionResult(HttpStatusCode.MethodNotAllowed, message, Request);
        }

        protected WebApiHttpActionResult BadRequest(string message)
        {
            return new WebApiHttpActionResult(HttpStatusCode.BadRequest, message, Request);
        }

        protected WebApiHttpActionResult InternalServerError(string message)
        {
            return new WebApiHttpActionResult(HttpStatusCode.InternalServerError, message, Request);
        }
    }
}
