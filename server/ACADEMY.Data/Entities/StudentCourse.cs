using System;
using System.Collections.Generic;

namespace ACADEMY.Data.Entities
{
    public class StudentCourse
    {
        public Guid StudentId { get; set; }

        public long CourseId { get; set; }

        public ICollection<Feedback> Feedbacks { get; set; }

        public User User { get; set; }

        public Course Course { get; set; }
    }
}