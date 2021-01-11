using System.Threading.Tasks;
using ACADEMY.Application.Requests.Catalog.Course;
using ACADEMY.Application.ViewModels.Catalog.Course;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Application.ViewModels.System;
using ACADEMY.Data.Entities;
using ACADEMY.Utilities.Dtos;

namespace ACADEMY.Application.Interfaces
{
    public interface IStudentService
    {
        Task<ApiResponse<UserVm>> GetInformationAsync();

        Task<ApiResponse<PagedResult<CourseVm>>> GetRegisteredCourseAsync(GetCoursesPagingRequest request);

        Task<ApiResponse<StudentCourse>> SubscribeCourseAsync(long courseId);
        Task<ApiResponse<bool>> UnsubscribeCourseAsync(long courseId);
        Task<bool> IsInCourseAsync(long id);
    }
}