using System;
using System.Collections.Generic;
using System.Text;

namespace ACADEMY.DataApplication.Entities
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
    }

}
