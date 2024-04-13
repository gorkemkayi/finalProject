using BookingApplication.Application.Features.Mediator.Queries.ReserveFlightQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FlightReserveController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FlightReserveController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetFlightsByAirport(int airportid,bool available)
        {
            GetReserveFlightQuery getReserveFlightQuery = new GetReserveFlightQuery()
            {
                Available = available,
                AirportId = airportid
            };
            var values = await _mediator.Send(getReserveFlightQuery);
            return Ok(values);
        }
    }
}
