using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACADEMY.Data.Enums;

namespace ACADEMY.Application.Requests.System
{
    public class PostUserRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên người dùng không được bỏ trống")]
        public string Name { get; set; }

        public UserGender Gender { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email không được bỏ trống")]
        public string Email { get; set; }

        public string Contact { get; set; }

        [Required(ErrorMessage = "Ngày sinh không được bỏ trống")]
        public DateTime DateOfBirth { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Số điện thoại không được bỏ trống")]
        public string PhoneNumber { get; set; }
    }
}
