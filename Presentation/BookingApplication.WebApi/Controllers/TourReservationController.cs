using BookingApplication.Application.Features.Mediator.Commands.TourReservationCommands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TourReservationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TourReservationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTourReservation(CreateTourReservationCommand createTourReservationCommand)
        {
            await _mediator.Send(createTourReservationCommand);
            return Ok("Rezervasyon Yapıldı");
        }
    }
}
