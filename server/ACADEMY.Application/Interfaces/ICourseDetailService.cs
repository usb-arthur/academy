using System.Collections.Generic;
using System.Threading.Tasks;
using ACADEMY.Application.Requests.Catalog.Course;
using ACADEMY.Application.ViewModels.Catalog.Course;
using ACADEMY.Application.ViewModels.Common;

namespace ACADEMY.Application.Interfaces
{
    public interface ICourseDetailService
    {
        Task<ApiResponse<ICollection<CourseDetailVm>>> GetAllAsync(long courseId);

        Task<ApiResponse<CourseDetailVm>> GetByIdAsync(long id);

        Task<ApiResponse<CourseDetailVm>> CreateAsync(PostCourseDetailRequest request);

        Task<ApiResponse<CourseDetailVm>> UpdateAsync(long id, PutCourseDetailRequest request);

        Task<ApiResponse<bool>> DeleteAsync(long id);
        Task<ApiResponse<bool>> UpdateDoneAsync(long id);
    }
}