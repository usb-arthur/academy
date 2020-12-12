using System.Collections.Generic;

namespace ACADEMY.Data.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        public long? CategoryId { get; set; }

        public ICollection<Category> Children { get; set; }

        public Category Parent { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}