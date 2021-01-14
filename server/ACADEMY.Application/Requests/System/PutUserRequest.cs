using System;
using System.ComponentModel.DataAnnotations;
using ACADEMY.Data.Enums;

namespace ACADEMY.Application.Requests.System
{
    public class PutUserRequest
    {
        [Required(ErrorMessage = "Tên không được bỏ trống")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Giới tính không được bỏ trống")]
        public UserGender Gender { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được bỏ trống")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Ngày sinh không được bỏ trống")]
        public DateTime? DateOfBirth { get; set; }
    }
}