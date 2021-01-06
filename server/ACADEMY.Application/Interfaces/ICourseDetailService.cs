using System.Collections.Generic;
using System.Threading.Tasks;
using ACADEMY.Application.Requests.Catalog.Course;
using ACADEMY.Application.ViewModels.Catalog.Course;
using ACADEMY.Application.ViewModels.Common;

namespace ACADEMY.Application.Interfaces
{
    public interface ICourseDetailService
    {
        Task<ApiResult<ICollection<CourseDetailVm>>> GetAllAsync(long courseId);

        Task<ApiResult<CourseDetailVm>> GetByIdAsync(long id);

        Task<ApiResult<CourseDetailVm>> CreateAsync(PostCourseDetailRequest request);

        Task<ApiResult<CourseDetailVm>> UpdateAsync(long id, PutCourseDetailRequest request);

        Task<ApiResult<bool>> DeleteAsync(long id);
    }
}