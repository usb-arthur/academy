using System.ComponentModel.DataAnnotations;

namespace ACADEMY.Application.Requests.System
{
    public class ChangePasswordRequest
    {
        [Required(ErrorMessage = "Password không được bỏ trống")]
        public string CurrentPassword { get; set; }

        [Required(ErrorMessage = "New password không được bỏ trống")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Confirm password không được bỏ trống")]
        [Compare("NewPassword", ErrorMessage = "Confirm password không trùng với new password")]
        public string ConfirmPassword { get; set; }
    }
}