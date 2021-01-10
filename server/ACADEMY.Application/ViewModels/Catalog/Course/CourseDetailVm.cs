namespace ACADEMY.Application.ViewModels.Catalog.Course
{
    public class CourseDetailVm
    {
        public long Id { get; set; }

        public string Content { get; set; }

        public string CreatedDate { get; set; }

        public string UpdatedDate { get; set; }

        public bool IsReview { get; set; }

        public bool IsPreview { get; set; }
    }
}