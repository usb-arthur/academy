using System.Collections.Generic;
using System.Threading.Tasks;
using ACADEMY.Application.Requests.Catalog.Course;
using ACADEMY.Application.Requests.System;
using ACADEMY.Application.ViewModels.Catalog.Course;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Application.ViewModels.System;
using ACADEMY.Utilities.Dtos;

namespace ACADEMY.Application.Interfaces
{
    public interface ITeacherService
    {
        Task<ApiResponse<UserVm>> GetInformationAsync();

        Task<ApiResponse<UserVm>> UpdateInformationAsync(PutTeacherRequest request);

        Task<ApiResponse<PagedResult<CourseVm>>> GetCoursesAsync(GetCoursesPagingRequest getCoursesPagingRequest);
    }
}