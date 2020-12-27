using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ACADEMY.Application.ViewModels.Common
{
    public class ApiResult<T>
    {
        public bool Succeeded { get; set; }

        public string Message { get; set; }

        public T Content { get; set; }

        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }
    }
}
