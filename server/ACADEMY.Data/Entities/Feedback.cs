using System;
using ACADEMY.Data.Interfaces;

namespace ACADEMY.Data.Entities
{
    public class Feedback : BaseEntity, IDateTracking, IHasOwner<Guid>
    {
        #region Properties

        public string Content { get; set; }

        public int Rate { get; set; }

        public Guid StudentId { get; set; }

        public long CourseId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid UpdatedBy { get; set; }

        #endregion

        #region Relationship

        public StudentCourse StudentCourse { get; set; }
        
        #endregion
    }
}