using System.ComponentModel.DataAnnotations;

namespace ACADEMY.Application.Requests.System
{
    public class ForgotPasswordRequest
    {
        [Required(ErrorMessage = "Email không được bỏ trống")]
        [EmailAddress]
        public string Email { get; set; }
    }
}