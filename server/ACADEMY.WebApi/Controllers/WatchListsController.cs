using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.Catalog.Course;
using ACADEMY.WebApi.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ACADEMY.WebApi.Controllers
{
    [ApiController]
    [Route("watch-lists")]
    [Authorize(Roles = "Student")]
    public class WatchListsController : ControllerBase
    {
        private readonly IWatchListService _watchListService;

        public WatchListsController(IWatchListService watchListService)
        {
            _watchListService = watchListService;
        }

        [HttpGet]
        public async Task<IActionResult> GetWatchLists()
        {
            var response = await _watchListService.GetAllAsync();

            return StatusCode((int) response.StatusCode, response);
        }

        [HttpGet("{id:long}")]
        public async Task<IActionResult> GetWatchList(long id)
        {
            var response = await _watchListService.GetByIdAsync(id);

            return StatusCode((int) response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> PostWatchList([FromBody] PostWatchListRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessage());

            var response = await _watchListService.CreateNewAsync(request);

            return StatusCode((int) response.StatusCode, response);
        }

        [HttpDelete("{id:long}")]
        public async Task<IActionResult> DeleteWatchListById(long id)
        {
            var response = await _watchListService.DeleteByIdAsync(id);

            return StatusCode((int) response.StatusCode, response);
        }

        [HttpGet("courses/{id:long}")]
        public async Task<IActionResult> DeleteWatchListByCourseId(long id)
        {
            var response = await _watchListService.DeleteByCourseIdAsync(id);

            return StatusCode((int) response.StatusCode, response);
        }
    }
}