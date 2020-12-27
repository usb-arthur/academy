using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACADEMY.Application.Requests.System;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Application.ViewModels.System;

namespace ACADEMY.Application.Interfaces
{
    public interface IAuthService
    {
        Task<ApiResult<AuthVm>> SignInAsync(SignInRequest request);

        Task<ApiResult<AuthVm>> RefreshTokenAsync(AuthRequest request);
    }
}
