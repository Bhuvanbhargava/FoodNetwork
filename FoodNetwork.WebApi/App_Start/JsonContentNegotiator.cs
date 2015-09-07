using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;

namespace FoodNetwork.WebApi
{
   
        public class JsonContentNegotiator : IContentNegotiator
        {
            private readonly JsonMediaTypeFormatter _jsonFormatter;
         

            public JsonContentNegotiator(JsonMediaTypeFormatter formatter)
            {
                _jsonFormatter = formatter;
                var settings = _jsonFormatter.SerializerSettings;
                settings.Formatting = Formatting.Indented;
                settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            }

            public ContentNegotiationResult Negotiate(Type type, HttpRequestMessage request, IEnumerable<MediaTypeFormatter> formatters)
            {
                var result = new ContentNegotiationResult(_jsonFormatter, new MediaTypeHeaderValue("application/json"));               
                
                return result;
            }
        }
    
}