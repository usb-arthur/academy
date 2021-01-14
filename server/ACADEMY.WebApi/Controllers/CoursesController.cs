using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.Catalog.Course;
using ACADEMY.Application.StorageService;
using ACADEMY.WebApi.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ACADEMY.WebApi.Controllers
{
    [ApiController]
    [Route("courses")]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;

        private readonly IStorageService _storageService;

        public CoursesController(ICourseService courseService, IStorageService storageService)
        {
            _courseService = courseService;
            _storageService = storageService;
        }

        [HttpGet]
        [Authorize(Roles = "Teacher")]
        public async Task<IActionResult> GetCourses()
        {
            return Ok(await _courseService.GetByTeacherAsync());
        }

        [HttpGet("all")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllCourses()
        {
            var response = await _courseService.GetAllAsync();
            
            return StatusCode((int)response.StatusCode, response);
        }
        
        [HttpGet("paging/teachers")]
        [Authorize(Roles = "Teacher")]
        public async Task<IActionResult> GetPagingByTeacher([FromQuery] GetCoursesPagingRequest request)
        {
            var response = await _courseService.GetPagingByTeacherAsync(request);
            
            return StatusCode((int)response.StatusCode, response);
        }
        
        [HttpGet("paging/categories/{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllCourses(long id, [FromQuery] GetCoursesPagingRequest request)
        {
            var response = await _courseService.GetPagingAsync(id, request);
            
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourse(int id)
        {
            var result = await _courseService.GetByIdAsync(id);

            return result.Succeeded ? Ok(result) : StatusCode((int) result.StatusCode, result);
        }

        [RequestFormLimits(ValueLengthLimit = int.MaxValue, MultipartBodyLengthLimit = int.MaxValue)]
        [DisableRequestSizeLimit]
        [HttpPost]
        [Consumes("multipart/form-data")]
        [Authorize(Roles = "Teacher")]
        public async Task<IActionResult> PostCourse([FromForm] PostCourseRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessage());

            var result = await _courseService.CreateAsync(request);

            return StatusCode((int) result.StatusCode, result);
        }

        [RequestFormLimits(ValueLengthLimit = int.MaxValue, MultipartBodyLengthLimit = int.MaxValue)]
        [DisableRequestSizeLimit]
        [HttpPut("{id}")]
        [Consumes("multipart/form-data")]
        [Authorize(Roles = "Teacher")]
        public async Task<IActionResult> PutCourse(int id, [FromForm] PutCourseRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessage());

            var result = await _courseService.UpdateAsync(id, request);

            return StatusCode((int) result.StatusCode, result);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("{courseId}/statistic/categories/{id}")]
        public async Task<IActionResult> GetRelativeCourse(long id, long courseId, [FromQuery] int payload)
        {
            var result = await _courseService.GetRelativeCourse(id, courseId, payload);

            return StatusCode((int) result.StatusCode, result);
        }
        
        [HttpPatch]
        [Route("{id}/status")]
        [Authorize(Roles = "Teacher")]
        public async Task<IActionResult> PatchCourse(long id, [FromBody] PatchCourseRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessage());

            var result = await _courseService.UpdateStatusAsync(id, request);

            return StatusCode((int) result.StatusCode, result);
        }

        [HttpGet("{id}/images")]
        [AllowAnonymous]
        public async Task<IActionResult> GetImageByCourseId(long id)
        {
            var imagePath = await _storageService.GetFilePathAsync("Courses", $"{id}.jpg");
            if (!System.IO.File.Exists(imagePath))
            {
                imagePath = await _storageService.GetFilePathAsync("Courses", "default.jpg");
            }
            var image = System.IO.File.OpenRead(imagePath);
            return File(image, "image/jpeg");
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Teacher,Admin")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            var result = await _courseService.DeleteAsync(id);

            return StatusCode((int) result.StatusCode, result);
        }
    }
}