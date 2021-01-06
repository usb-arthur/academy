using System.Collections.Generic;
using System.Threading.Tasks;
using ACADEMY.Application.Requests.Catalog.Category;
using ACADEMY.Application.ViewModels.Catalog.Category;
using ACADEMY.Application.ViewModels.Common;

namespace ACADEMY.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<ApiResult<ICollection<CategoryVm>>> GetAllAsync();

        Task<ApiResult<CategoryVm>> GetByIdAsync(long id);

        Task<ApiResult<CategoryVm>> CreateAsync(PostCategoryRequest request);

        Task<ApiResult<CategoryVm>> UpdateAsync(long id, PutCategoryRequest request);

        Task<ApiResult<bool>> DeleteAsync(long id);
    }
}