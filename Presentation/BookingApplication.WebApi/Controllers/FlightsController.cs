using BookingApplication.Application.Features.CQRS.Commands.FlightCommands;
using BookingApplication.Application.Features.CQRS.Handlers.FlightHandlers;
using BookingApplication.Application.Features.CQRS.Queries.FlightQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly CreateFlightCommandHandler _createFlightCommandHandler;
        private readonly GetFlightByIdQueryHandler _getFlightByIdQueryHandler;
        private readonly GetFlightQueryHandler _getFlightQueryHandler;
        private readonly RemoveFlightCommandHandler _removeFlightCommandHandler;
        private readonly UpdateFlightCommandHandler _updateFlightCommandHandler;
        private readonly GetFeaturedFlightsQueryHandler _getFeaturedFlightsQueryHandler;

        public FlightsController(CreateFlightCommandHandler createFlightCommandHandler, GetFlightByIdQueryHandler getFlightByIdQueryHandler, GetFlightQueryHandler getFlightQueryHandler, RemoveFlightCommandHandler removeFlightCommandHandler, UpdateFlightCommandHandler updateFlightCommandHandler, GetFeaturedFlightsQueryHandler getFeaturedFlightsQueryHandler)
        {
            _createFlightCommandHandler = createFlightCommandHandler;
            _getFlightByIdQueryHandler = getFlightByIdQueryHandler;
            _getFlightQueryHandler = getFlightQueryHandler;
            _removeFlightCommandHandler = removeFlightCommandHandler;
            _updateFlightCommandHandler = updateFlightCommandHandler;
            _getFeaturedFlightsQueryHandler = getFeaturedFlightsQueryHandler;
        }

        [HttpGet]
        public IActionResult FlightList()
        {
            var values = _getFlightQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetFlight(int id)
        {
            var value = _getFlightByIdQueryHandler.Handle(new GetFlightByIdQueries(id));
            return Ok(value);
        }
        [HttpGet]
        public IActionResult GetFeaturedFlights()
        {
            var values= _getFeaturedFlightsQueryHandler.Handle();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateFlight(CreateFlightCommand command)
        {
            await _createFlightCommandHandler.Handle(command);
            return Ok("Flight Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveFlight(int id)
        {
            await _removeFlightCommandHandler.Handle(new RemoveFlightCommand(id));
            return Ok("Uçuş Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFlight(UpdateFlightCommand command)
        {
            await _updateFlightCommandHandler.Handle(command);
            return Ok("Flight Güncellendi");
        }

    }
}
