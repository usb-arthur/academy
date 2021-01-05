using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACADEMY.Data.Enums;

namespace ACADEMY.Application.ViewModels.System
{
    public class UserVm
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public string DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }
    }
}
