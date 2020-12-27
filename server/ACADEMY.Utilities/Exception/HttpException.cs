using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMY.Utilities.Exception
{
    public class HttpException : System.Exception
    {
        private readonly int _httpStatusCode;

        public HttpException(int httpStatusCode)
        {
            this._httpStatusCode = httpStatusCode;
        }

        public HttpException(HttpStatusCode httpStatusCode)
        {
            this._httpStatusCode = (int)httpStatusCode;
        }

        public HttpException(int httpStatusCode, string message) : base(message)
        {
            this._httpStatusCode = httpStatusCode;
        }

        public HttpException(HttpStatusCode httpStatusCode, string message) : base(message)
        {
            this._httpStatusCode = (int)httpStatusCode;
        }

        public HttpException(int httpStatusCode, string message, System.Exception inner) : base(message, inner)
        {
            this._httpStatusCode = httpStatusCode;
        }

        public HttpException(HttpStatusCode httpStatusCode, string message, System.Exception inner) : base(message, inner)
        {
            this._httpStatusCode = (int)httpStatusCode;
        }

        public int StatusCode => this._httpStatusCode;
    }
}
