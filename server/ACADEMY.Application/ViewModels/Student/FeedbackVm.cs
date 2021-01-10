using System;
using ACADEMY.Application.ViewModels.System;
using ACADEMY.Data.Entities;

namespace ACADEMY.Application.ViewModels.Student
{
    public class FeedbackVm
    {
        public long Id { get; set; }

        public string Content { get; set; }

        public int Rate { get; set; }

        public Guid StudentId { get; set; }
        
        public UserVm Student { get; set; }
        
        public string CreatedDate { get; set; }

        public string UpdatedDate { get; set; }
    }
}