using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace FoodNetwork.WebApi.Common
{
    public class WebApiHttpActionResult :IHttpActionResult
    {
        public  string _message { get; set; }
        public  HttpRequestMessage _requestMessage { get; set; }
        private HttpStatusCode _statusCode { get; set; }
       
        public WebApiHttpActionResult(HttpStatusCode statusCode,string message,HttpRequestMessage requestMessage)
        {
            _statusCode = statusCode;
            _message= message;
            _requestMessage= requestMessage;

        }

        public WebApiHttpActionResult(HttpStatusCode statusCode, string message)
        {
            _statusCode = statusCode;
            _message = message;           

        }                
        
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            IContentNegotiator negotiator = GlobalConfiguration.Configuration.Services.GetContentNegotiator();
            ContentNegotiationResult result = negotiator.Negotiate(typeof(Dictionary<string, string>), _requestMessage, GlobalConfiguration.Configuration.Formatters);
            var message = new Dictionary<string,string>()
            {
                {"Code",_statusCode.ToString("D")},
                {"Message",_message}
            };
            var responseMessage = new HttpResponseMessage()
            {
                StatusCode = _statusCode,
                Content = new ObjectContent<Dictionary<string,string>>(message,result.Formatter,result.MediaType.MediaType ),
                RequestMessage = _requestMessage ?? new HttpRequestMessage()
            };
            return Task.FromResult(responseMessage);
        }
    
    }


   
}