using BookingApplication.Application.Features.Mediator.Commands.FlightReservationCommands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebApi.Controllers
{
    [Authorize(Roles ="Member,Admin")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FlightReservationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FlightReservationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateFlightReservation(CreateFlightReservationCommand createFlightReservationCommand)
        {
            await _mediator.Send(createFlightReservationCommand);
            return Ok("Rezervasyon Eklendi");
        }
    }
}
