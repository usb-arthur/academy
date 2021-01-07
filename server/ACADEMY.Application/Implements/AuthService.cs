using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.System;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Application.ViewModels.System;
using ACADEMY.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace ACADEMY.Application.Implements
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _config;

        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;


        public AuthService(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _config = config;
        }

        public async Task<ApiResponse<AuthVm>> SignInAsync(SignInRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
                return new ApiErrorResponse<AuthVm>($"User {request.Email} không tồn tại", HttpStatusCode.NotFound);

            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);

            if (!result.Succeeded)
                return new ApiErrorResponse<AuthVm>("Password không đúng", HttpStatusCode.BadRequest);

            var token = await Sign(user);

            user.RefreshToken = GenerateRefreshToken();

            var succeed = await _userManager.UpdateAsync(user);


            if (!succeed.Succeeded)
                return new ApiErrorResponse<AuthVm>("Không thể khởi tạo token", HttpStatusCode.InternalServerError);
            ;

            return new ApiSucceedResponse<AuthVm>(new AuthVm
            {
                AccessToken = token,
                Email = user.Email,
                Name = user.Name,
                Id = user.Id,
                RefreshToken = user.RefreshToken
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