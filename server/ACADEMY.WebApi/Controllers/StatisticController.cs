using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ACADEMY.WebApi.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("statistic")]
    public class StatisticController : ControllerBase
    {
        private readonly IStatisticService _statisticService;

        public StatisticController(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }

        [HttpGet]
        public async Task<IActionResult> GetStatistic([FromQuery] GetStatisticRequest request)
        {
            if (request.Payload == null || request.Criteria == null)
            {
                return BadRequest();
            }

            var result = await _statisticService.GetPopularAsync(request.Payload.Value, request.Criteria.Value);

            return StatusCode((int) result.StatusCode, result);
        }
    }
}