using System.Net;
using Newtonsoft.Json;

namespace ACADEMY.Application.ViewModels.Common
{
    public class ApiResponse<T>
    {
        public bool Succeeded { get; set; }

        public string Message { get; set; }

        public T ObjResult { get; set; }

        [global::System.Text.Json.Serialization.JsonIgnore] public HttpStatusCode StatusCode { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}