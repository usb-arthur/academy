using System;
using System.ComponentModel.DataAnnotations;
using ACADEMY.Data.Enums;

namespace ACADEMY.Application.Requests.System
{
    public class PutTeacherRequest
    {
        [Required(ErrorMessage = "Tên không được bỏ trống")]
        public string Name { get; set; }

        public string Contact { get; set; }

        [Required(ErrorMessage = "Giới tính không được bỏ trống")]
        public UserGender Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được bỏ trống")]
        public string PhoneNumber { get; set; }
    }
}