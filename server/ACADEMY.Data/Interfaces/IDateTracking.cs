using System;

namespace ACADEMY.Data.Interfaces
{
    public interface IDateTracking
    {
        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}