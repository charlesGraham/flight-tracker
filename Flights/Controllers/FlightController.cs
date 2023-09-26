using Flights.ReadModels;
using Microsoft.AspNetCore.Mvc;

namespace Flights.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightController : ControllerBase
    {

        private readonly ILogger<FlightController> _logger;

        public FlightController(ILogger<FlightController> logger)
        {
            _logger = logger;
        }

        Random random = new Random();

        [HttpGet]
        public IEnumerable<FlightRm> Search()
        {
            return new FlightRm[] {
                new(
                    Guid.NewGuid(),
                    "American Airlines",
                    random.Next(90, 500).ToString(),
                    new TimePlaceRm("LostAngeles", DateTime.Now.AddHours(random.Next(1, 15))),
                    new TimePlaceRm("Hawaii", DateTime.Now.AddHours(random.Next(4, 19))),
                    random.Next(1, 853)
                ),
                new(
                    Guid.NewGuid(),
                    "Adria Airways",
                    random.Next(90, 500).ToString(),
                    new TimePlaceRm("Ljubljana", DateTime.Now.AddHours(random.Next(1, 15))),
                    new TimePlaceRm("Warsaw", DateTime.Now.AddHours(random.Next(4, 19))),
                    random.Next(1, 853)
                ),
                new(
                    Guid.NewGuid(),
                    "Deutsche BA",
                    random.Next(90, 500).ToString(),
                    new TimePlaceRm("Munchen", DateTime.Now.AddHours(random.Next(1, 15))),
                    new TimePlaceRm("Schiphol", DateTime.Now.AddHours(random.Next(4, 19))),
                    random.Next(1, 853)
                ),
                new(
                    Guid.NewGuid(),
                    "Japan Airlines",
                    random.Next(90, 500).ToString(),
                    new TimePlaceRm("San Francisco", DateTime.Now.AddHours(random.Next(1, 15))),
                    new TimePlaceRm("Tokyo", DateTime.Now.AddHours(random.Next(4, 19))),
                    random.Next(1, 853)
                ),
            };
        }
    }
}