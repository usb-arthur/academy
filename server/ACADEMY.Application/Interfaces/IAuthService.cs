using System.Threading.Tasks;
using ACADEMY.Application.Requests.Common;
using ACADEMY.Application.Requests.System;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Application.ViewModels.System;

namespace ACADEMY.Application.Interfaces
{
    public interface IAuthService
    {
        Task<ApiResponse<AuthVm>> SignInAsync(SignInRequest request);

        Task<ApiResponse<AuthVm>> RefreshTokenAsync(AuthRequest request);

        Task<ApiResponse<bool>> ChangePasswordAsync(ChangePasswordRequest request);
        Task<ApiResponse<UserVm>> RegisterAsync(RegisterRequest request);
        Task<ApiResponse<string>> GeneratePasswordResetTokenAsync(ForgotPasswordRequest request);
        Task<ApiResponse<bool>> ResetPasswordAsync(ResetPasswordRequest request);
    }
}