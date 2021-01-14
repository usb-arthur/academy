using System;
using ACADEMY.Application.ViewModels.Catalog.Category;
using ACADEMY.Application.ViewModels.System;
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

        public double? Sale { get; set; }

        public string SaleDate { get; set; }

        public double? Rate { get; set; }

        public CategoryVm Category { get; set; }

        public bool New { get; set; }

        public bool BestSeller => NumOfStudent > 10;

        public double ActualPrice
        {
            get
            {
                if (Sale != null && !string.IsNullOrEmpty(SaleDate))
                {
                    return CourseFee * Sale.Value / 100;
                }

                return CourseFee;
            }
        }

        public int? DateLeft
        {
            get
            {
                if (Sale != null && !string.IsNullOrEmpty(SaleDate))
                {
                    return (DateTime.Parse(SaleDate) - DateTime.Now).Days;
                }

                return null;
            }
        }

        public int? NumOfFeedback { get; set; }

        public int? NumOfStudent { get; set; }

        public int NumOfView { get; set; }

        public UserVm User { get; set; }
        
        public string Status { get; set; }

        public CourseStatus CourseStatus { get; set; }

        public string CreatedDate { get; set; }

        public string UpdatedDate { get; set; }
    }
}