using System.Collections.Generic;
using System.Threading.Tasks;
using ACADEMY.Application.Requests.Catalog.Course;
using ACADEMY.Application.ViewModels.Catalog.Course;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Utilities.Dtos;

namespace ACADEMY.Application.Interfaces
{
    public interface IWatchListService
    {
        Task<ApiResponse<PagedResult<CourseVm>>> GetAllAsync(GetCoursesPagingRequest request);

        Task<ApiResponse<WatchListVm>> GetByIdAsync(long id);

        Task<ApiResponse<WatchListVm>> CreateNewAsync(PostWatchListRequest request);

        Task<ApiResponse<bool>> DeleteByCourseIdAsync(long courseId);

        Task<ApiResponse<bool>> DeleteByIdAsync(long id);
    }
}