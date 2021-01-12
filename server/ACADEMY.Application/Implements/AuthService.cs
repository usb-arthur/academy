using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ACADEMY.Application.EmailService;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.Common;
using ACADEMY.Application.Requests.System;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Application.ViewModels.System;
using ACADEMY.Data.Entities;
using ACADEMY.Data.Enums;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace ACADEMY.Application.Implements
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _config;

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        private readonly IEmailService _emailService;

        public AuthService(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration config,
            IHttpContextAccessor httpContextAccessor, IMapper mapper, IEmailService emailService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _config = config;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _emailService = emailService;
        }

        public async Task<ApiResponse<AuthVm>> SignInAsync(SignInRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
                return new ApiErrorResponse<AuthVm>($"User {request.Email} không tồn tại", HttpStatusCode.NotFound);

            if (user.Status == UserStatus.Deactivated)
                return new ApiErrorResponse<AuthVm>(
                    "Tài khoản của bạn hiện tại đang bị khoá. Vui lòng liên hệ admin để mở khoá tài khoản",
                    HttpStatusCode.BadRequest);

            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);

            if (!result.Succeeded)
                return new ApiErrorResponse<AuthVm>("Password không đúng", HttpStatusCode.BadRequest);

            var token = await Sign(user);

            user.RefreshToken = GenerateRefreshToken();

            var succeed = await _userManager.UpdateAsync(user);


            if (!succeed.Succeeded)
                return new ApiErrorResponse<AuthVm>("Không thể khởi tạo token", HttpStatusCode.InternalServerError);

            var roles = await _userManager.GetRolesAsync(user);
            return new ApiSucceedResponse<AuthVm>(new AuthVm
            {
                AccessToken = token,
                Email = user.Email,
                Name = user.Name,
                Id = user.Id,
                RefreshToken = user.RefreshToken,
                Roles = string.Join(",", roles)
            });
        }

        public async Task<ApiResponse<AuthVm>> RefreshTokenAsync(AuthRequest request)
        {
            var userPrincipal = DecodeToken(request.AccessToken);

            var email = userPrincipal.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.Email)?.Value;

            if (string.IsNullOrEmpty(email))
                return new ApiErrorResponse<AuthVm>("Token không hợp lệ", HttpStatusCode.BadRequest);

            var user = await _userManager.FindByEmailAsync(email);

            if (!user.RefreshToken.Equals(request.RefreshToken))
                return new ApiErrorResponse<AuthVm>("Token khÔng hợp lệ", HttpStatusCode.BadRequest);

            var token = await Sign(user);
            return new ApiSucceedResponse<AuthVm>(new AuthVm
            {
                AccessToken = token,
                Email = user.Email,
                Id = user.Id,
                Name = user.Name,
                RefreshToken = user.RefreshToken
            });
        }

        public async Task<ApiResponse<bool>> ChangePasswordAsync(ChangePasswordRequest request)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid);

            var user = await _userManager.FindByIdAsync(userId);

            var result = await _userManager.ChangePasswordAsync(user, request.CurrentPassword, request.NewPassword);

            if (result.Succeeded) return new ApiSucceedResponse<bool>(true);

            return new ApiErrorResponse<bool>(result.Errors.ToList()[0].Description, HttpStatusCode.BadRequest);
        }

        public async Task<ApiResponse<UserVm>> RegisterAsync(RegisterRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user != null)
                return new ApiErrorResponse<UserVm>("Email đã được dùng để đăng ký tài khoản khác",
                    HttpStatusCode.Conflict);

            user = _mapper.Map<RegisterRequest, User>(request);

            user.CreatedDate = user.UpdatedDate = DateTime.Now;

            user.FirstLogin = false;
            user.UserName = request.Email;
            user.NormalizedEmail = user.NormalizedUserName = _userManager.NormalizeEmail(request.Email);
            var result = await _userManager.CreateAsync(user, request.Password);

            if (!result.Succeeded)
                return new ApiErrorResponse<UserVm>("Thao tác tạo user không thành công",
                    HttpStatusCode.InternalServerError);

            result = await _userManager.AddToRoleAsync(user, "Student");

            if (result.Succeeded)
                return new ApiSucceedResponse<UserVm>(_mapper.Map<User, UserVm>(user))
                    {StatusCode = HttpStatusCode.Created};

            return new ApiErrorResponse<UserVm>($"Không thể khởi tạo role cho người dùng {user.Email}",
                HttpStatusCode.InternalServerError);
        }

        public async Task<ApiResponse<bool>> ResetPasswordAsync(ResetPasswordRequest request)
        {
            if (string.IsNullOrEmpty(request.Email) || string.IsNullOrEmpty(request.Token))
            {
                return new ApiErrorResponse<bool>(
                    "Thao tác đổi mật khẩu không thành công vì token hết hạn hoặc email không tồn tại",
                    HttpStatusCode.BadRequest);
            }

            var user = await _userManager.FindByEmailAsync(request.Email);
            
            if (user == null)
            {
                return new ApiErrorResponse<bool>($"Người dùng {request.Email} không tồn tại", HttpStatusCode.NotFound);
            }

            var result = await _userManager.ResetPasswordAsync(user, request.Token, request.Password);

            if (!result.Succeeded)
            {
                return new ApiErrorResponse<bool>(result.Errors.FirstOrDefault()?.Description,
                    HttpStatusCode.NotModified);
            }

            return new ApiSucceedResponse<bool>(true);
        }
        
        public async Task<ApiResponse<string>> GeneratePasswordResetTokenAsync(ForgotPasswordRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
            {
                return new ApiErrorResponse<string>($"Người dùng {request.Email} không tồn tại", HttpStatusCode.NotFound);
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            return new ApiSucceedResponse<string>(token);
        }

        private static JwtSecurityToken DecodeToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.ReadToken(token) as JwtSecurityToken;
        }

        private async Task<string> Sign(User user)
        {
            var roles = await _userManager.GetRolesAsync(user);

            var claims = new[]
            {
                new Claim(ClaimTypes.Sid, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, string.Join(";", roles))
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(3),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private static string GenerateRefreshToken()
        {
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                var randomBytes = new byte[64];
                rngCryptoServiceProvider.GetBytes(randomBytes);
                return Convert.ToBase64String(randomBytes);
            }
        }
    }
}