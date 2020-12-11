using System;
using System.Collections.Generic;
using System.Text;

namespace ACADEMY.DataApplication.Entities
{
    public class WatchList
    {
        public Guid StudentId { get; set; }
        public long CourseId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public User User { get; set; }
        public Course Courses { get; set; }
    }
}
