using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodNetwork.WebApi.Common
{
    public class CustomArgumentException : Exception
    {
        public int HResult { get; set; }
        public string Message { get; set; }

        public CustomArgumentException(int hResult, string message)
        {
            HResult = hResult;
            Message= message;
        }
    }
}