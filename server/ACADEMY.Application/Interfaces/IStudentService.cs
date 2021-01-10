using System.Collections.Generic;
using System.Threading.Tasks;
using ACADEMY.Application.ViewModels.Catalog.Course;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Application.ViewModels.System;
using ACADEMY.Data.Entities;

namespace ACADEMY.Application.Interfaces
{
    public interface IStudentService
    {
        Task<ApiResponse<UserVm>> GetInformationAsync();

        Task<ApiResponse<ICollection<CourseVm>>> GetRegisteredCourseAsync();

        Task<ApiResponse<StudentCourse>> SubscribeCourseAsync(long courseId);
        Task<ApiResponse<bool>> UnsubscribeCourseAsync(long courseId);
    }
}