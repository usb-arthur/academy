using System;
using ACADEMY.Data.Interfaces;

namespace ACADEMY.Data.Entities
{
    public class WatchList: IDateTracking, IHasOwner<Guid>
    {
        #region Properties

        public Guid StudentId { get; set; }

        public long CourseId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid UpdatedBy { get; set; }

        #endregion

        #region Relationship

        public virtual User User { get; set; }

        public virtual Course Courses { get; set; }

        #endregion
    }
}