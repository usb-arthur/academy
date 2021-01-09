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
    [Authorize(Roles = "Teacher")]
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
        public async Task<IActionResult> GetCourses()
        {
            return Ok(await _courseService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourse(int id)
        {
            var result = await _courseService.GetByIdAsync(id);

            return result.Succeeded ? Ok(result) : StatusCode((int) result.StatusCode, result);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> PostCourse([FromForm] PostCourseRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessage());

            var result = await _courseService.CreateAsync(request);

            return StatusCode((int) result.StatusCode, result);
        }

        [HttpPut("{id}")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> PutCourse(int id, [FromForm] PutCourseRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessage());

            var result = await _courseService.UpdateAsync(id, request);

            return StatusCode((int) result.StatusCode, result);
        }

        [HttpGet("{id}/images")]
        public async Task<IActionResult> GetImageByCourseId(long id)
        {
            var imagePath = await _storageService.GetImagePathAsync("Courses", $"{id}.jpg");
            var image = System.IO.File.OpenRead(imagePath);
            return File(image, "image/jpeg");
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            var result = await _courseService.DeleteAsync(id);

            return StatusCode((int) result.StatusCode, result);
        }
    }
}