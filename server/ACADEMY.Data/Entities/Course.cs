using System;
using System.Collections.Generic;
using ACADEMY.Data.Enums;
using ACADEMY.Data.Interfaces;
using ACADEMY.Infrastructure.SharedKernel;

namespace ACADEMY.Data.Entities
{
    public class Course : DomainEntity<long>, IDateTracking, IHasOwner<Guid>, ISortable, IHasSoftDelete
    {
        #region Properties

        public string CourseName { get; set; }

        public double CourseFee { get; set; }

        public double? Sale { get; set; }

        public DateTime? SaleDate { get; set; }

        public string BriefDescription { get; set; }

        public string DetailDescription { get; set; }

        public CourseStatus Status { get; set; }

        public long CategoryId { get; set; }

        public Guid TeacherId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid UpdatedBy { get; set; }

        public int SortOrder { get; set; }

        public bool IsDeleted { get; set; }

        #endregion

        #region Relationship

        public Category Category { get; set; }

        public User Teacher { get; set; }

        public ICollection<WatchList> WatchLists { get; set; }

        public ICollection<Feedback> Feedbacks { get; set; }
        
        public ICollection<StudentCourse> StudentCourses { get; set; }

        public ICollection<CourseDetail> CourseDetails { get; set; }

        #endregion
    }
}