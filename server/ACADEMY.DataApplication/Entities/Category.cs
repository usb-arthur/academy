using System;
using System.Collections.Generic;
using System.Text;

namespace ACADEMY.DataApplication.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        public long CategoryId { get; set; }

        public List<Category> Children { get; set; }

        public Category Parent { get; set; }

        public List<Course> Courses { get; set; }
    }
}
