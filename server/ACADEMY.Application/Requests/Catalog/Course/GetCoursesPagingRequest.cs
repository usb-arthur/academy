using ACADEMY.Application.Requests.Common;

namespace ACADEMY.Application.Requests.Catalog.Course
{
    public class GetCoursesPagingRequest : PagingRequestBase
    {
        public string Search { get; set; }
    }
}