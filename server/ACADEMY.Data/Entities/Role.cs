using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ACADEMY.Data.Entities
{
    public class Role : IdentityRole<Guid>
    {
        #region Relationship

        public ICollection<User> Users { get; set; }

        #endregion
    }
}