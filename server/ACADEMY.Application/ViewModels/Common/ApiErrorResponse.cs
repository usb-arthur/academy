using System.Net;

namespace ACADEMY.Application.ViewModels.Common
{
    public class ApiErrorResponse<T> : ApiResponse<T>
    {
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

        public string[] ValidationErrors { get; set; }
    }
}