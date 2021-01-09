using System;
using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.Common;
using ACADEMY.Application.Requests.System;
using ACADEMY.WebApi.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ACADEMY.WebApi.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("sign-in")]
        public async Task<IActionResult> SignIn([FromBody] SignInRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessage());

            var authResult = await _authService.SignInAsync(request);
            if (authResult.Succeeded) SetTokenCookie(authResult.ObjResult.RefreshToken);

            return StatusCode((int) authResult.StatusCode, authResult);
        }

        [HttpPost]
        [Route("refresh-token")]
        public async Task<IActionResult> RefreshTokenAsync([FromBody] AuthRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!Request.Cookies.TryGetValue("refreshToken", out var token))
                return BadRequest("Token đã hết hạn hoặc không tồn tại");

            request.RefreshToken = token;

            var result = await _authService.RefreshTokenAsync(request);

            return StatusCode((int) result.StatusCode, result);
        }

        [HttpPost]
        [Route("change-password")]
        [Authorize]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessage());
            }

            var response = await _authService.ChangePasswordAsync(request);

            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessage());
            }

            var response = await _authService.RegisterAsync(request);

            return StatusCode((int)response.StatusCode, response);
        }
        
        private void SetTokenCookie(string token)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddYears(1)
            };
            Response.Cookies.Append("refreshToken", token, cookieOptions);
        }
    }
}