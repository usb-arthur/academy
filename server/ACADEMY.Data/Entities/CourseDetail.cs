using System;
using ACADEMY.Data.Interfaces;
using ACADEMY.Infrastructure.SharedKernel;

namespace ACADEMY.Data.Entities
{
    public class CourseDetail : DomainEntity<long>, IDateTracking
    {
        #region RelationShip

        public Course Course { get; set; }

        #endregion

        #region Properties

        public long CourseId { get; set; }

        public string Content { get; set; }

        public bool IsReview { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool Done { get; set; }

        #endregion
    }
}