using System.Collections.Generic;
using System.Threading.Tasks;
using ACADEMY.Application.Requests.Catalog.Category;
using ACADEMY.Application.ViewModels.Catalog.Category;
using ACADEMY.Application.ViewModels.Common;

namespace ACADEMY.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<ApiResponse<ICollection<CategoryVm>>> GetAllAsync();

        Task<ApiResponse<CategoryVm>> GetByIdAsync(long id);

        Task<ApiResponse<CategoryVm>> CreateAsync(PostCategoryRequest request);

        Task<ApiResponse<CategoryVm>> UpdateAsync(long id, PutCategoryRequest request);

        Task<ApiResponse<bool>> DeleteAsync(long id);
    }
}