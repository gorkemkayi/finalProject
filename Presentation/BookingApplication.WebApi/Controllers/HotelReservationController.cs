using BookingApplication.Application.Features.Mediator.Commands.HotelReservationCommands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebApi.Controllers
{
    [Authorize(Roles ="Member,Admin")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HotelReservationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HotelReservationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateHotelReservation(CreateHotelReservationCommand createHotelReservationCommand)
        {
            await _mediator.Send(createHotelReservationCommand);
            return Ok("Rezervasyon Eklendi");
        }
    }
}
