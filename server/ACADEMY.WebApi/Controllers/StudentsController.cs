using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ACADEMY.WebApi.Controllers
{
    [ApiController]
    [Route("students")]
    [Authorize(Roles = "Student")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("information")]
        public async Task<IActionResult> GetInformation()
        {
            var response = await _studentService.GetInformationAsync();

            return StatusCode((int) response.StatusCode, response);
        }

        [HttpGet("courses")]
        public async Task<IActionResult> GetRegisteredCourses()
        {
            var response = await _studentService.GetRegisteredCourseAsync();
            
            return StatusCode((int) response.StatusCode, response);
        }
    }
}