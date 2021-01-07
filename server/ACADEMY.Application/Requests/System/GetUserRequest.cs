using ACADEMY.Application.Requests.Common;

namespace ACADEMY.Application.Requests.System
{
    public class GetUserRequest : PagingRequestBase
    {
        public string Search { get; set; }


        public int OrderBy { get; set; } = 0;
    }
}