using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Propella.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertiesController : ControllerBase
    {
        private readonly ILogger<PropertiesController> _logger;

        public PropertiesController(ILogger<PropertiesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Property> Get()
        {
            return new List<Property>
            {
                new() {Address = "123 East St", Bedrooms = 2, BuildingType = "Home"},
                new() {Address = "12/3 George St", Bedrooms = 1, BuildingType = "Unit"},
            };
        }
    }
}