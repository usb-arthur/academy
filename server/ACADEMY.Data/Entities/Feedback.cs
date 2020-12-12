using System;

namespace ACADEMY.Data.Entities
{
    public class Feedback : BaseEntity
    {
        public string Content { get; set; }

        public int Rate { get; set; }

        public Guid StudentId { get; set; }

        public long CourseId { get; set; }

        public StudentCourse StudentCourse { get; set; }
    }
}