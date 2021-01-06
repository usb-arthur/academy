using System;
using System.Collections.Generic;
using ACADEMY.Data.Interfaces;

namespace ACADEMY.Data.Entities
{
    public class StudentCourse : IDateTracking
    {
        #region Properties

        public Guid StudentId { get; set; }

        public long CourseId { get; set; }

        public ICollection<Feedback> Feedbacks { get; set; }

        public DateTime CreatedDate { get; set; }
        
        public DateTime UpdatedDate { get; set; }
        
        #endregion

        #region Relationship

        public virtual User User { get; set; }

        public virtual Course Course { get; set; }

        #endregion
    }
}