using System;

namespace ACADEMY.Data.Entities
{
    public class WatchList
    {
        public Guid StudentId { get; set; }

        public long CourseId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public long CreatedBy { get; set; }

        public long UpdatedBy { get; set; }

        public User User { get; set; }

        public Course Courses { get; set; }
    }
}