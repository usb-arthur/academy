using System.ComponentModel.DataAnnotations;

namespace ACADEMY.Data.Enums
{
    public enum CourseStatus
    {
        [Display(Name = "Hoàn thành")] Completed,
        [Display(Name = "Chưa hoàn thành")] Incomplete
    }
}