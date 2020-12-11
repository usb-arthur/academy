using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACADEMY.DataApplication.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public List<User> Users { get; set; }
    }
}
