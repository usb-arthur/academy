using ACADEMY.Application.ViewModels.System;

namespace ACADEMY.Application.ViewModels.Catalog.Course
{
    public class WatchListVm
    {
        public long Id { get; set; }

        public long CourseId { get; set; }

        public UserVm User { get; set; }

        public CourseVm Course { get; set; }
    }
}