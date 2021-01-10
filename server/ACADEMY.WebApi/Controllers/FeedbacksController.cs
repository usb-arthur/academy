using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.Student;
using ACADEMY.WebApi.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ACADEMY.WebApi.Controllers
{
    [ApiController]
    [Route("feedbacks")]
    public class FeedbacksController : ControllerBase
    {
        private readonly IFeedbackService _feedbackService;

        public FeedbacksController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        [HttpGet("courses/{id:long}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetFeedbacksByCourseId(long id)
        {
            var result = await _feedbackService.GetAllAsync(id);

            return StatusCode((int) result.StatusCode, result);
        }

        [HttpPost]
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> PostFeedback([FromBody] PostFeedbackRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessage());

            var result = await _feedbackService.WriteFeedbackAsync(request);

            return StatusCode((int) result.StatusCode, result);
        }

        [HttpPut("{id:long}")]
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> PutFeedback(long id, [FromBody] PutFeedbackRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessage());

            var result = await _feedbackService.EditFeedbackAsync(id, request);

            return StatusCode((int) result.StatusCode, result);
        }

        [HttpDelete("{id:long}")]
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> DeleteFeedback(long id)
        {
            var result = await _feedbackService.RemoveFeedbackAsync(id);

            return StatusCode((int) result.StatusCode, result);
        }
    }
}