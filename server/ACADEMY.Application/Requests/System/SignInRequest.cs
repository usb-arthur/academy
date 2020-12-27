using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMY.Application.Requests.System
{
    public class SignInRequest
    {
        [Required(ErrorMessage = "Email không được bỏ trống", AllowEmptyStrings = false)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Email không được bỏ trống", AllowEmptyStrings = false)]
        public string Password { get; set; }

        public bool RememberMe { get; set; } = false;
    }
}
