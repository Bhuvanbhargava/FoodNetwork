using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ExceptionHandling;

namespace FoodNetwork.WebApi.Common
{
    /// <summary>
    /// Trace Exception Logger
    /// </summary>
    public class WebApiExceptionLogger : ExceptionLogger
    {
        public override void Log(ExceptionLoggerContext context)
        {
            //either use tracing for logging
           // Trace.TraceError(context.ExceptionContext.Exception.ToString());
            //or use Semantic Logging Application Block(SLAB)  
            //FoodnetworkEventSource.Log.  ScalingRequestSubmitted(
            //  request.RoleName,
            //  request.InstanceCount,
            //  context.RuleName,
            //  context.CurrentInstanceCount);
        }
    }
}