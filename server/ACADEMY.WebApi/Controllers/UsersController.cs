using System;
using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.System;
using ACADEMY.WebApi.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ACADEMY.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _userService.GetAllAsync();

            return StatusCode((int) result.StatusCode, result);
        }
        
        [HttpGet("information")]
        [Authorize]
        public async Task<IActionResult> GetInformation()
        {
            var response = await _userService.GetInformationAsync();

            return StatusCode((int) response.StatusCode, response);
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var result = await _userService.GetByIdAsync(id);

            return StatusCode((int) result.StatusCode, result);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] PostUserRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var result = await _userService.AddAsync(request);

            return StatusCode((int) result.StatusCode, result);
        }

        [Authorize]
        [HttpPatch("{id}")]
        public async Task<IActionResult> PutUser(Guid id, [FromBody] PutUserRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessage());

            var result = await _userService.UpdateAsync(id, request);

            return StatusCode((int) result.StatusCode, result);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var result = await _userService.DeleteAsync(id);

            return StatusCode((int) result.StatusCode, result);
        }
    }
}