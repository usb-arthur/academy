using ACADEMY.Application.Enums.Course;
using ACADEMY.Application.Requests.Common;

namespace ACADEMY.Application.Requests.Catalog.Course
{
    public class GetCoursesPagingRequest : PagingRequestBase
    {
        public string Search { get; set; }

        public CourseOrder Order { get; set; } = CourseOrder.Ascending;

        public CourseSort SortBy { get; set; } = CourseSort.Name;
    }
}