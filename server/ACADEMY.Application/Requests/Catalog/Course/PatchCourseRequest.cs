using ACADEMY.Data.Enums;

namespace ACADEMY.Application.Requests.Catalog.Course
{
    public class PatchCourseRequest
    {
        public CourseStatus Status { get; set; }
    }
}