using System;
using System.Collections.Generic;
using ACADEMY.Data.Enums;

namespace ACADEMY.Data.Entities
{
    public class Course : BaseEntity
    {
        public string CourseName { get; set; }

        public double CourseFee { get; set; }

        public string BriefDescription { get; set; }

        public string DetailDescription { get; set; }

        public CourseStatus Status { get; set; }

        public long CategoryId { get; set; }

        public Guid TeacherId { get; set; }

        public Category Category { get; set; }

        public User Teacher { get; set; }

        public ICollection<WatchList> WatchLists { get; set; }
    }
}