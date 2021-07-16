using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Propella.Application.Queries;

namespace Propella.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertySearchController : ControllerBase
    {
        private readonly ILogger<PropertiesController> _logger;
        private readonly IMediator _mediator;

        public PropertySearchController(ILogger<PropertiesController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<int> GetCountAsync()
        {
            return (await _mediator.Send(new GetResidentialSearch())).Data;
        }
    }
}