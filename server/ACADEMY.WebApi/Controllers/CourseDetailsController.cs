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
    [Route("course-details")]
    public class CourseDetailsController : ControllerBase
    {
        private readonly ICourseDetailService _courseDetailService;

        private readonly IStorageService _storageService;

        public CourseDetailsController(ICourseDetailService courseDetailService, IStorageService storageService)
        {
            _courseDetailService = courseDetailService;
            _storageService = storageService;
        }

        [HttpGet("courses/{id:long}")]
        [Authorize(Roles = "Teacher")]
        public async Task<IActionResult> GetCourseDetails(long id)
        {
            var response = await _courseDetailService.GetAllAsync(id);

            return StatusCode((int) response.StatusCode, response);
        }

        [HttpGet("{id:long}")]
        [Authorize(Roles = "Teacher")]
        public async Task<IActionResult> GetCourseDetail(long id)
        {
            var response = await _courseDetailService.GetByIdAsync(id);

            return StatusCode((int) response.StatusCode, response);
        }

        [RequestFormLimits(ValueLengthLimit = int.MaxValue, MultipartBodyLengthLimit = int.MaxValue)]
        [DisableRequestSizeLimit]
        [HttpPost]
        [Consumes("multipart/form-data")]
        [Authorize(Roles = "Teacher")]
        public async Task<IActionResult> PostCourseDetail([FromForm] PostCourseDetailRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessage());

            var response = await _courseDetailService.CreateAsync(request);

            return StatusCode((int) response.StatusCode, response);
        }

        [HttpGet("{id}/videos")]
        public async Task<IActionResult> GetCourseDetailVideo(long id)
        {
            var videoPath = await _storageService.GetFilePathAsync("CourseDetails", $"{id}.mp4");
            if (!System.IO.File.Exists(videoPath)) return NotFound("Không tìm thấy video");
            var video = System.IO.File.OpenRead(videoPath);
            return File(video, "video/webm", true);
        }

        [HttpPut("{id:long}")]
        [Authorize(Roles = "Teacher")]
        public async Task<IActionResult> PutCourseDetail(long id, [FromBody] PutCourseDetailRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessage());

            var response = await _courseDetailService.UpdateAsync(id, request);

            return StatusCode((int) response.StatusCode, response);
        }

        [HttpDelete("{id:long}")]
        [Authorize(Roles = "Teacher")]
        public async Task<IActionResult> DeleteCourseDetail(long id)
        {
            var response = await _courseDetailService.DeleteAsync(id);

            return StatusCode((int) response.StatusCode, response);
        }
    }
}