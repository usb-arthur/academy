using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ACADEMY.Application.Requests.System;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Application.ViewModels.System;

namespace ACADEMY.Application.Interfaces
{
    public interface IUserService
    {
        Task<ApiResponse<UserVm>> AddAsync(PostUserRequest request);

        Task<ApiResponse<bool>> DeleteAsync(Guid id);

        Task<ApiResponse<ICollection<UserVm>>> GetAllAsync();

        Task<ApiResponse<UserVm>> GetByIdAsync(Guid id);

        Task<ApiResponse<UserVm>> UpdateAsync(Guid id, PutUserRequest request);
    }
}