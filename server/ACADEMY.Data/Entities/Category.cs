using System;
using System.Collections.Generic;
using ACADEMY.Data.Interfaces;

namespace ACADEMY.Data.Entities
{
    public class Category : BaseEntity, IDateTracking, IHasOwner<Guid>
    {
        public string CategoryName { get; set; }

        public long? CategoryId { get; set; }

        public ICollection<Category> Children { get; set; }

        public Category Parent { get; set; }

        public ICollection<Course> Courses { get; set; }
        
        public DateTime CreatedDate { get; set; }
        
        public DateTime UpdatedDate { get; set; }
        
        public Guid CreatedBy { get; set; }
        
        public Guid UpdatedBy { get; set; }
    }
}