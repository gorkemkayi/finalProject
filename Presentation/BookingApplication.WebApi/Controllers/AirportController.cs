using BookingApplication.Application.Features.CQRS.Commands.AirportCommands;
using BookingApplication.Application.Features.CQRS.Handlers.AirportHandlers;
using BookingApplication.Application.Features.CQRS.Queries.AirportQueries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebApi.Controllers
{    
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly CreateAirportCommandHandler _createAirportCommandHandler;
        private readonly GetAirportByIdQueryHandler _getAirportByIdQueryHandler;
        private readonly GetAirportQueryHandler _getAirportQueryHandler;
        private readonly RemoveAirportCommandHandler _removeAirportCommandHandler;
        private readonly UpdateAirportCommandHandler _updateAirportCommandHandler;

        public AirportController(CreateAirportCommandHandler createAirportCommandHandler, GetAirportByIdQueryHandler getAirportByIdQueryHandler, GetAirportQueryHandler getAirportQueryHandler, RemoveAirportCommandHandler removeAirportCommandHandler, UpdateAirportCommandHandler updateAirportCommandHandler)
        {
            _createAirportCommandHandler = createAirportCommandHandler;
            _getAirportByIdQueryHandler = getAirportByIdQueryHandler;
            _getAirportQueryHandler = getAirportQueryHandler;
            _removeAirportCommandHandler = removeAirportCommandHandler;
            _updateAirportCommandHandler = updateAirportCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> AirportList()
        {
            var values = await _getAirportQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAirport(int id)
        {
            var value = await _getAirportByIdQueryHandler.Handle(new GetAirportByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAirport(CreateAirportCommand command)
        {
            await _createAirportCommandHandler.Handle(command);
            return Ok("Airport Eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAirport(UpdateAirportCommand command)
        {
            await _updateAirportCommandHandler.Handle(command);
            return Ok("Airport Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveAirport(int id)
        {
            await _removeAirportCommandHandler.Handle(new RemoveAirportCommand(id));
            return Ok("Airport Silindi");
        }
    }
}
