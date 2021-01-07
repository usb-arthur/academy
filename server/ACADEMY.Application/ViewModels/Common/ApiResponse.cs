using System.Net;
using System.Text.Json.Serialization;

namespace ACADEMY.Application.ViewModels.Common
{
    public class ApiResponse<T>
    {
        public bool Succeeded { get; set; }

        public string Message { get; set; }

        public T ObjResult { get; set; }

        [JsonIgnore] public HttpStatusCode StatusCode { get; set; }
    }
}