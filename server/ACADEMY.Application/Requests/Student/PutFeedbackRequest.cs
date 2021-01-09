using System.ComponentModel.DataAnnotations;

namespace ACADEMY.Application.Requests.Student
{
    public class PutFeedbackRequest
    {
        [Required(ErrorMessage = "Bạn đang đánh giá khoá học nào?")]
        public long CourseId { get; set; }

        [Required(ErrorMessage = "Nội dung đánh giá không được bỏ trống")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Bạn cho khoá học này mấy điểm?")]
        public int Rate { get; set; }
    }
}