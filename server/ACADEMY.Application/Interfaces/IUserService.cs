using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ACADEMY.Application.Requests.System;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Application.ViewModels.System;
using ACADEMY.Utilities.Dtos;

namespace ACADEMY.Application.Interfaces
{
    public interface IUserService
    {
        Task<ApiResult<UserVm>> AddAsync(PostUserRequest request);

        Task<ApiResult<bool>> DeleteAsync(Guid id);

        Task<ApiResult<ICollection<UserVm>>> GetAllAsync();

        Task<ApiResult<UserVm>> GetByIdAsync(Guid id);

        Task<ApiResult<UserVm>> UpdateAsync(Guid id, PutUserRequest request);
    }
}
