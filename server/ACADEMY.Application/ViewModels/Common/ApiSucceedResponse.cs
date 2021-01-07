using System.Net;

namespace ACADEMY.Application.ViewModels.Common
{
    public class ApiSucceedResponse<T> : ApiResponse<T>
    {
        public ApiSucceedResponse(T content)
        {
            StatusCode = HttpStatusCode.OK;
            Succeeded = true;
            ObjResult = content;
        }

        public ApiSucceedResponse(T content, HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
            Succeeded = true;
            ObjResult = content;
        }

        public ApiSucceedResponse()
        {
            Succeeded = true;
        }
    }
}