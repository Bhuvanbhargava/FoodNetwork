using FoodNetwork.WebApi.Common;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Diagnostics;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Tracing;


namespace FoodNetwork.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();
    
            // Web API configuration and services
            config.Services.Add(typeof(IExceptionLogger), new WebApiExceptionLogger());
            config.Services.Replace(typeof(IExceptionHandler), new WebApiExceptionHandler());
            #region FoodNetworkTraceWriter
            // Step 2: create a WebApiEtwTraceWriter and register it
            // with the WebApi configuration's services.  This registration
            // effectively enables tracing from the WebAPI core.            
            FoodNetworkTraceWriter traceWriter = new FoodNetworkTraceWriter();
            config.Services.Replace(typeof(System.Web.Http.Tracing.ITraceWriter), traceWriter);

            // Uncomment the next 2 lines to remove all filtering and to
            // allow every trace request to trace to ETW.
            // The default filters permit only a small
            // subset of traces to reduce the noise.
            // Alternatively, provide your own predicates here to
            // control which trace requests are sent to ETW.

            //traceWriter.TraceRequestFilter = null;
            //traceWriter.TraceRecordFilter = null; 
            #endregion

            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));
       

            //Forcing Json Formatter
            var jsonFormatter = new JsonMediaTypeFormatter();
            //serializer settings
            var settings = jsonFormatter.SerializerSettings;
            settings.Formatting = Formatting.Indented;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Services.Replace(typeof(IContentNegotiator), new JsonContentNegotiator(jsonFormatter));

            

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
