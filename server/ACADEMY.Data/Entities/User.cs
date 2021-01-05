using System;
using System.Collections.Generic;
using ACADEMY.Data.Enums;
using ACADEMY.Data.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace ACADEMY.Data.Entities
{
    public class User : IdentityUser<Guid>, IDateTracking, IHasOwner<Guid>
    {
        #region Properties

        public string Name { get; set; }

        public UserGender Gender { get; set; }

        public string Contact { get; set; }
        
        public UserStatus Status { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid UpdatedBy { get; set; }

        public bool FirstLogin { get; set; }
        
        public string RefreshToken { get; set; }

        #endregion

        #region Relationship

        public virtual ICollection<WatchList> WatchLists { get; set; }
        
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        
        public virtual ICollection<Course> Courses { get; set; }

        #endregion
    }
}