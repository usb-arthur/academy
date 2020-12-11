using ACADEMY.DataApplication.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACADEMY.DataApplication.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string Name { get; set; }
        public UserGender Gender { get; set; }
        public string Contact { get; set; }
        public UserStatus Status { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<Course> Courses { get; set; }

        public List<WatchList> WatchLists { get; set; }
        public List<Role> Roles { get; set; }
    }
}
