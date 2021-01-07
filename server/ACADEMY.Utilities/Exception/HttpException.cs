using System.Net;

namespace ACADEMY.Utilities.Exception
{
    public class HttpException : System.Exception
    {
        public HttpException(int httpStatusCode)
        {
            StatusCode = httpStatusCode;
        }

        public HttpException(HttpStatusCode httpStatusCode)
        {
            StatusCode = (int) httpStatusCode;
        }

        public HttpException(int httpStatusCode, string message) : base(message)
        {
            StatusCode = httpStatusCode;
        }

        public HttpException(HttpStatusCode httpStatusCode, string message) : base(message)
        {
            StatusCode = (int) httpStatusCode;
        }

        public HttpException(int httpStatusCode, string message, System.Exception inner) : base(message, inner)
        {
            StatusCode = httpStatusCode;
        }

        public HttpException(HttpStatusCode httpStatusCode, string message, System.Exception inner) : base(message,
            inner)
        {
            StatusCode = (int) httpStatusCode;
        }

        public int StatusCode { get; }
    }
}