using System;
using ACADEMY.Data.Interfaces;
using ACADEMY.Infrastructure.SharedKernel;

namespace ACADEMY.Data.Entities
{
    public class CourseDetail : DomainEntity<long>, IDateTracking
    {
        #region Properties

        public long CourseId { get; set; }
        
        public string Content { get; set; }

        public bool IsReview { get; set; }
        
        public DateTime CreatedDate { get; set; }
        
        public DateTime UpdatedDate { get; set; }

        #endregion

        #region RelationShip

        public Course Course { get; set; }

        #endregion
        
    }
}