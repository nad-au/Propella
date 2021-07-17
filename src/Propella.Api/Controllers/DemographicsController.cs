using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Propella.Application.Queries;

namespace Propella.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemographicsController : ControllerBase
    {
        private readonly ILogger<DemographicsController> _logger;
        private readonly IMediator _mediator;

        public DemographicsController(ILogger<DemographicsController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<int> GetCountAsync()
        {
            return (await _mediator.Send(new GetDemographics())).Data;
        }
    }
}