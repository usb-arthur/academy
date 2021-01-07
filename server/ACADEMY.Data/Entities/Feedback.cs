using System;
using ACADEMY.Data.Interfaces;
using ACADEMY.Infrastructure.SharedKernel;

namespace ACADEMY.Data.Entities
{
    public class Feedback : DomainEntity<long>, IDateTracking, IHasOwner<Guid>
    {
        #region Relationship

        public virtual StudentCourse StudentCourse { get; set; }

        #endregion

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
    }
}