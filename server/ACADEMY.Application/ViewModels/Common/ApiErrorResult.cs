using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMY.Application.ViewModels.Common
{
    public class ApiErrorResult<T> : ApiResult<T>
    {
        public string[] ValidationErrors { get; set; }

        public ApiErrorResult()
        {
            Succeeded = false;
        }

        public ApiErrorResult(string message, HttpStatusCode statusCode)
        {
            Succeeded = false;
            Message = message;
            StatusCode = statusCode;
        }

        public ApiErrorResult(string[] validationErrors)
        {
            Succeeded = false;
            ValidationErrors = validationErrors;
        }
    }
}
