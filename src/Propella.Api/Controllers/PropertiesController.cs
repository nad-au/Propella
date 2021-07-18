using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Propella.Application.Queries.GetProperties;
using Propella.Domain;

namespace Propella.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertiesController : ControllerBase
    {
        private readonly ILogger<PropertiesController> _logger;
        private readonly IMediator _mediator;

        public PropertiesController(ILogger<PropertiesController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Property>> GetProperties()
        {
            return (await _mediator.Send(new GetPropertiesQuery())).Data;
        }
    }
}