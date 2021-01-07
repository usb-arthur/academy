using System.Collections.Generic;
using System.Threading.Tasks;
using ACADEMY.Application.Requests.System;
using ACADEMY.Application.ViewModels.Catalog.Course;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Application.ViewModels.System;

namespace ACADEMY.Application.Interfaces
{
    public interface ITeacherService
    {
        Task<ApiResult<UserVm>> GetInformationAsync();

        Task<ApiResult<UserVm>> UpdateInformationAsync(PutTeacherRequest request);

        Task<ApiResult<ICollection<CourseVm>>> GetCoursesAsync();
    }
}

