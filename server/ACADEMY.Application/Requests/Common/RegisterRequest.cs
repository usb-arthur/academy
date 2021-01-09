using System;
using System.ComponentModel.DataAnnotations;
using ACADEMY.Data.Enums;

namespace ACADEMY.Application.Requests.Common
{
    public class RegisterRequest
    {
        [Required(ErrorMessage = "Email không được để trống")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Xác nhận mật khẩu không được để trống")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Tên không được bỏ để trống")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Giới tính không được bỏ trống")]
        public UserGender Gender { get; set; }

        [Required(ErrorMessage = "Ngày sinh không được bỏ trống")]
        public DateTime DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }
    }
}