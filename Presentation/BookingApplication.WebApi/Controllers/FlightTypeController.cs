using BookingApplication.Application.Features.CQRS.Commands.FlightTypeCommands;
using BookingApplication.Application.Features.CQRS.Handlers.FlightTypeHandlers;
using BookingApplication.Application.Features.CQRS.Queries.FlightTypeQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FlightTypeController : ControllerBase
    {
        private readonly CreateFlightTypeCommandHandler _createFlightTypeCommandHandler;
        private readonly GetFlightTypeByIdQueryHandler _getFlightTypeByIdQueryHandler;
        private readonly GetFlightTypeQueryHandler _getFlightTypeQueryHandler;
        private readonly RemoveFlightTypeCommandHandler _removeFlightTypeCommandHandler;
        private readonly UpdateFlightTypeCommandHandler _updateFlightTypeCommandHandler;

        public FlightTypeController(CreateFlightTypeCommandHandler createFlightTypeCommandHandler, GetFlightTypeByIdQueryHandler getFlightTypeByIdQueryHandler, GetFlightTypeQueryHandler getFlightTypeQueryHandler, RemoveFlightTypeCommandHandler removeFlightTypeCommandHandler, UpdateFlightTypeCommandHandler updateFlightTypeCommandHandler)
        {
            _createFlightTypeCommandHandler = createFlightTypeCommandHandler;
            _getFlightTypeByIdQueryHandler = getFlightTypeByIdQueryHandler;
            _getFlightTypeQueryHandler = getFlightTypeQueryHandler;
            _removeFlightTypeCommandHandler = removeFlightTypeCommandHandler;
            _updateFlightTypeCommandHandler = updateFlightTypeCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> FlightTypeList()
        {
            var values = await _getFlightTypeQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFlightType(int id)
        {
            var value = await _getFlightTypeByIdQueryHandler.Handle(new GetFlightTypeByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateFlightType(CreateFlightTypeCommand command)
        {
            await _createFlightTypeCommandHandler.Handle(command);
            return Ok("FlightType Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFlightType(UpdateFlightTypeCommand command)
        {
            await _updateFlightTypeCommandHandler.Handle(command);
            return Ok("FlightType Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveFlightType(int id)
        {
            await _removeFlightTypeCommandHandler.Handle(new RemoveFlightTypeCommand(id));
            return Ok("FlightType Silindi");
        }
    }
}
