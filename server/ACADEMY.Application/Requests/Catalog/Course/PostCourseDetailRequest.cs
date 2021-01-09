using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ACADEMY.Application.Requests.Catalog.Course
{
    public class PostCourseDetailRequest
    {
        [Required(ErrorMessage = "Không tìm thấy khoá học tương ứng")]
        public long CourseId { get; set; }

        [Required(ErrorMessage = "Nội dung không được bỏ trống")]
        public string Content { get; set; }

        public bool IsReview { get; set; } = false;

        [Required(ErrorMessage = "Mỗi chương phải có một video tương ứng")]
        public IFormFile Video { get; set; }
    }
}