using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ACADEMY.Data.Interfaces;
using ACADEMY.Infrastructure.SharedKernel;

namespace ACADEMY.Data.Entities
{
    public class Category : DomainEntity<long>, IDateTracking, IHasOwner<Guid>
    {
        #region Properties

        public string CategoryName { get; set; }

        public long? CategoryId { get; set; }
        
        public DateTime CreatedDate { get; set; }
        
        public DateTime UpdatedDate { get; set; }
        
        public Guid CreatedBy { get; set; }
        
        public Guid UpdatedBy { get; set; }

        #endregion

        #region Relationship

        public virtual ICollection<Category> Children { get; set; }

        public virtual Category Parent { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual User UpdatedUser { get; set; }

        public virtual User CreatedUser { get; set; }
        
        #endregion
    }
}