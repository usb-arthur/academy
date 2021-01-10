using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ACADEMY.WebApi.Controllers
{
    [ApiController]
    [Route("students")]
    [Authorize(Roles = "Student,Admin,Teacher")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        /// <summary>
        ///     Lấy thông tin học viên
        /// </summary>
        /// <returns></returns>
        [HttpGet("information")]
        public async Task<IActionResult> GetInformation()
        {
            var response = await _studentService.GetInformationAsync();

            return StatusCode((int) response.StatusCode, response);
        }

        /// <summary>
        ///     Lấy danh sách khoá học được học viên đăng ký
        /// </summary>
        /// <returns></returns>
        [HttpGet("courses")]
        public async Task<IActionResult> GetRegisteredCourses()
        {
            var response = await _studentService.GetRegisteredCourseAsync();

            return StatusCode((int) response.StatusCode, response);
        }

        /// <summary>
        ///     Đăng ký khoá học
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("courses/{id:long}")]
        public async Task<IActionResult> SubscribeCourse(long id)
        {
            var result = await _studentService.SubscribeCourseAsync(id);

            return StatusCode((int) result.StatusCode, result);
        }

        [HttpDelete("courses/{id:long}")]
        public async Task<IActionResult> UnsubscribeCourse(long id)
        {
            var result = await _studentService.UnsubscribeCourseAsync(id);

            return StatusCode((int) result.StatusCode, result);
        }
    }
}