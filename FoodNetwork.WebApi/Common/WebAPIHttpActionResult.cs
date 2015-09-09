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
    /// <summary>
    /// WebApiHttpActionResult
    /// </summary>
    public class WebApiHttpActionResult :IHttpActionResult
    {
        private string _message { get; set; }
        private HttpRequestMessage _requestMessage { get; set; }
        private HttpStatusCode _statusCode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebApiHttpActionResult"/> class.
        /// </summary>
        /// <param name="statusCode">The status code.</param>
        /// <param name="message">The message.</param>
        /// <param name="requestMessage">The request message.</param>
        public WebApiHttpActionResult(HttpStatusCode statusCode,string message,HttpRequestMessage requestMessage)
        {
            _statusCode = statusCode;
            _message= message;
            _requestMessage= requestMessage;

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebApiHttpActionResult"/> class.
        /// </summary>
        /// <param name="statusCode">The status code.</param>
        /// <param name="message">The message.</param>
        public WebApiHttpActionResult(HttpStatusCode statusCode, string message)
        {
            _statusCode = statusCode;
            _message = message;           

        }

        /// <summary>
        /// Creates an <see cref="T:System.Net.Http.HttpResponseMessage" /> asynchronously.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>
        /// A task that, when completed, contains the <see cref="T:System.Net.Http.HttpResponseMessage" />.
        /// </returns>
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