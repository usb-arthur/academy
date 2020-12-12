using System;
using System.Collections.Generic;
using ACADEMY.Data.Enums;
using ACADEMY.Data.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace ACADEMY.Data.Entities
{
    public class User : IdentityUser<Guid>, IDateTracking, IHasOwner<Guid>
    {
        public string Name { get; set; }

        public UserGender Gender { get; set; }

        public string Contact { get; set; }
        public UserStatus Status { get; set; }

        public DateTime DateOfBirth { get; set; }

        public ICollection<Course> Courses { get; set; }

        public ICollection<WatchList> WatchLists { get; set; }

        public ICollection<Role> Roles { get; set; }
        
        public DateTime CreatedDate { get; set; }
        
        public DateTime UpdatedDate { get; set; }
        
        public Guid CreatedBy { get; set; }
        
        public Guid UpdatedBy { get; set; }
    }
}