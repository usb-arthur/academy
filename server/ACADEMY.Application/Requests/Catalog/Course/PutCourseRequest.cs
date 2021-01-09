using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ACADEMY.Application.Requests.Catalog.Course
{
    public class PutCourseRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên khoá học không được bỏ trống")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Gía khoá học không được bỏ trống")]
        public float CourseFee { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Mô tả ngắn gọn không được bỏ trống")]
        public string BriefDescription { get; set; }

        public string DetailDescription { get; set; }

        [FileExtensions(Extensions = "jpg,jpeg", ErrorMessage = "Chỉ cho phép file jpg")]
        public IFormFile Image { get; set; }
    }
}