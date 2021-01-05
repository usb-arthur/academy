using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACADEMY.Application.Requests.Catalog.Course;
using ACADEMY.Application.ViewModels.Catalog.Course;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Utilities.Dtos;

namespace ACADEMY.Application.Interfaces
{
    public interface ICourseService
    {
        Task<ApiResult<ICollection<CourseVm>>> GetAllAsync();

        Task<ApiResult<CourseVm>> GetByIdAsync(int id);

        Task<ApiResult<CourseVm>> CreateAsync(PostCourseRequest request);

        Task<ApiResult<CourseVm>> UpdateAsync(int id, PutCourseRequest request);

        Task<ApiResult<bool>> DeleteAsync(int id);
    }
}
