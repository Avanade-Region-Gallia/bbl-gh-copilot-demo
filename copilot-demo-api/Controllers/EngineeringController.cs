using Microsoft.AspNetCore.Mvc;

namespace copilot_demo_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EngineeringController : ControllerBase
    {
        private readonly ILogger<EngineeringController> _logger;
        private readonly EngineeringPartDataAccess _dataAccess = new();

        public EngineeringController(ILogger<EngineeringController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("parts")]
        public IEnumerable<EngineeringPartDto> Get()
        {
            return _dataAccess.Get(null);
        }

        [HttpGet]
        [Route("parts/{name}")]
        public IEnumerable<EngineeringPartDto> Get(string name)
        {
            return _dataAccess.Get(name.ToUpperInvariant());
        }


        [HttpGet]
        [Route("parts/search")]
        public IEnumerable<EngineeringPartDto> Recherche([FromQuery] string? description)
        {
            var toutesLesPieces = _dataAccess.Get(null);

            if (description != null)
            {
                return toutesLesPieces.Where(p => p.Description?.Contains(description, StringComparison.OrdinalIgnoreCase) == true);
            }
            return toutesLesPieces.Where(p => p.Description is null);
        }
    }
}
