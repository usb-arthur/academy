using System.ComponentModel.DataAnnotations;

namespace ACADEMY.Application.Requests.System
{
    public class ResetPasswordRequest
    {
        [Required(ErrorMessage = "Xác nhận mật khẩu không được bỏ trống")]
        [Compare("Password", ErrorMessage = "Mật khẩu không khớp với xác nhận mật khẩu")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được bỏ trống")]
        public string Password { get; set; }

        public string Token { get; set; }

        public string Email { get; set; }
    }
}