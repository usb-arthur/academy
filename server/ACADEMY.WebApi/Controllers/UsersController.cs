using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ACADEMY.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "Admin")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers([FromQuery] GetUserRequest request)
        {
            var result = await _userService.GetAllPagingAsync(request);

            return StatusCode((int)result.StatusCode, result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var result = await _userService.GetByIdAsync(id);

            return StatusCode((int) result.StatusCode, result);
        }

        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] PostUserRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _userService.AddAsync(request);

            return StatusCode((int) result.StatusCode, result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(Guid id, [FromBody] PutUserRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _userService.UpdateAsync(id, request);

            return StatusCode((int)result.StatusCode, result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var result = await _userService.DeleteAsync(id);

            return StatusCode((int)result.StatusCode, result);
        }
    }
}
