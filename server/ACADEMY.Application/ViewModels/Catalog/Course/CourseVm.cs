using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACADEMY.Data.Enums;

namespace ACADEMY.Application.ViewModels.Catalog.Course
{
    public class CourseVm
    {
        public long Id { get; set; }

        public string CourseName { get; set; }

        public double CourseFee { get; set; }

        public string BriefDescription { get; set; }

        public string DetailDescription { get; set; }
        
        public double Rate { get; set; }

        public int NumOfFeedback { get; set; }

        public int NumOfStudent { get; set; }
        
        public CourseStatus Status { get; set; }

        public string CreatedDate { get; set; }

        public string UpdatedDate { get; set; }
    }
}
