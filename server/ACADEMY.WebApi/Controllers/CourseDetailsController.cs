using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.Catalog.Course;
using ACADEMY.WebApi.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ACADEMY.WebApi.Controllers
{
    [ApiController]
    [Route("course-details")]
    [Authorize(Roles = "Teacher")]
    public class CourseDetailsController : ControllerBase
    {
        private readonly ICourseDetailService _courseDetailService;

        public CourseDetailsController(ICourseDetailService courseDetailService)
        {
            _courseDetailService = courseDetailService;
        }

        [HttpGet("courses/{id:long}")]
        public async Task<IActionResult> GetCourseDetails(long id)
        {
            var response = await _courseDetailService.GetAllAsync(id);

            return StatusCode((int) response.StatusCode, response);
        }

        [HttpGet("{id:long}")]
        public async Task<IActionResult> GetCourseDetail(long id)
        {
            var response = await _courseDetailService.GetByIdAsync(id);

            return StatusCode((int) response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> PostCourseDetail([FromBody] PostCourseDetailRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessage());

            var response = await _courseDetailService.CreateAsync(request);

            return StatusCode((int) response.StatusCode, response);
        }

        [HttpPut("{id:long}")]
        public async Task<IActionResult> PutCourseDetail(long id, [FromBody] PutCourseDetailRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessage());

            var response = await _courseDetailService.UpdateAsync(id, request);

            return StatusCode((int) response.StatusCode, response);
        }

        [HttpDelete("{id:long}")]
        public async Task<IActionResult> DeleteCourseDetail(long id)
        {
            var response = await _courseDetailService.DeleteAsync(id);

            return StatusCode((int) response.StatusCode, response);
        }
    }
}