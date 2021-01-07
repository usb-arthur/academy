using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMY.Application.ViewModels.Common
{
    public class ApiErrorResponse<T> : ApiResponse<T>
    {
        public string[] ValidationErrors { get; set; }

        public ApiErrorResponse()
        {
            Succeeded = false;
        }

        public ApiErrorResponse(string message, HttpStatusCode statusCode)
        {
            Succeeded = false;
            Message = message;
            StatusCode = statusCode;
        }

        public ApiErrorResponse(string[] validationErrors)
        {
            Succeeded = false;
            ValidationErrors = validationErrors;
        }
    }
}
