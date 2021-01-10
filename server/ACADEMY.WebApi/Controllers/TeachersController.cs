using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.Catalog.Course;
using ACADEMY.Application.Requests.System;
using ACADEMY.WebApi.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ACADEMY.WebApi.Controllers
{
    [ApiController]
    [Authorize(Roles = "Teacher")]
    [Route("teachers")]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeachersController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet("information")]
        public async Task<IActionResult> GetInformation()
        {
            var response = await _teacherService.GetInformationAsync();

            return StatusCode((int) response.StatusCode, response);
        }

        [HttpGet("courses")]
        public async Task<IActionResult> GetCourses(GetCoursesPagingRequest request)
        {
            var response = await _teacherService.GetCoursesAsync(request);

            return StatusCode((int) response.StatusCode, response);
        }

        [HttpPut]
        public async Task<IActionResult> PutTeacher([FromBody] PutTeacherRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessage());

            var response = await _teacherService.UpdateInformationAsync(request);

            return StatusCode((int) response.StatusCode, response);
        }
    }
}