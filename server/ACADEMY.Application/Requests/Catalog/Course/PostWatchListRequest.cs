using System.ComponentModel.DataAnnotations;

namespace ACADEMY.Application.Requests.Catalog.Course
{
    public class PostWatchListRequest
    {
        [Required(ErrorMessage = "Bạn đang chọn khoá học nào?")]
        public long CourseId { get; set; }
    }
}