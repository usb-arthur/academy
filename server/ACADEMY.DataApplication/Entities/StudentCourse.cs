using System;
using System.Collections.Generic;
using System.Text;

namespace ACADEMY.DataApplication.Entities
{
    public class StudentCourse
    {
        public Guid StudentId { get; set; }
        public long CourseId { get; set; }

        public List<Feedback> Feedbacks { get; set; }

        public User User { get; set; }

        public Course Course { get; set; }
    }
}
