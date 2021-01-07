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
        Task<ApiResponse<ICollection<CourseVm>>> GetAllAsync();

        Task<ApiResponse<CourseVm>> GetByIdAsync(long id);

        Task<ApiResponse<CourseVm>> CreateAsync(PostCourseRequest request);

        Task<ApiResponse<CourseVm>> UpdateAsync(long id, PutCourseRequest request);

        Task<ApiResponse<bool>> DeleteAsync(int id);
    }
}
