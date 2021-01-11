using System.ComponentModel.DataAnnotations;

namespace ACADEMY.Application.Requests.System
{
    public class SignInRequest
    {
        [Required(ErrorMessage = "Email không được bỏ trống", AllowEmptyStrings = false)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được bỏ trống", AllowEmptyStrings = false)]
        public string Password { get; set; }

        public bool RememberMe { get; set; } = false;
    }
}