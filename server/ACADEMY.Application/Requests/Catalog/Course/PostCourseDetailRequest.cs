using System.ComponentModel.DataAnnotations;

namespace ACADEMY.Application.Requests.Catalog.Course
{
    public class PostCourseDetailRequest
    {
        [Required(ErrorMessage = "Không tìm thấy khoá học tương ứng")]
        public long CourseId { get; set; }

        [Required(ErrorMessage = "Nội dung không được bỏ trống")]
        public string Content { get; set; }

        public bool? IsPreview { get; set; }
    }
}