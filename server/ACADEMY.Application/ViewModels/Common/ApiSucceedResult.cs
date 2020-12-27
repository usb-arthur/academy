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
            Content = content;
        }

        public ApiSucceedResult()
        {
            Succeeded = true;
        }
    }
}
