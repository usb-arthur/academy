using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMY.Application.ViewModels.Common
{
    public class ApiSucceedResult<T> : ApiResult<T>
    {
        public ApiSucceedResult(T content)
        {
            StatusCode = HttpStatusCode.OK;
            Succeeded = true;
            ObjResult = content;
        }

        public ApiSucceedResult(T content, HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
            Succeeded = true;
            ObjResult = content;
        }
        
        public ApiSucceedResult()
        {
            Succeeded = true;
        }
    }
}
