using BookingApplication.Application.Features.CQRS.Commands.AirlineCommands;
using BookingApplication.Application.Features.CQRS.Handlers.AirlineHandlers;
using BookingApplication.Application.Features.CQRS.Queries.AirlineQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AirlineController : ControllerBase
    {
        private readonly CreateAirlineCommandHandler _createAirlineCommandHandler;
        private readonly GetAirlineByIdQueryHandler _getAirlineByIdQueryHandler;
        private readonly GetAirlineQueryHandler _getAirlineQueryHandler;
        private readonly RemoveAirlineCommandHandler _removeAirlineCommandHandler;
        private readonly UpdateAirlineCommandHandler _updateAirlineCommandHandler;

        public AirlineController(CreateAirlineCommandHandler createAirlineCommandHandler, GetAirlineByIdQueryHandler getAirlineByIdQueryHandler, GetAirlineQueryHandler getAirlineQueryHandler, RemoveAirlineCommandHandler removeAirlineCommandHandler, UpdateAirlineCommandHandler updateAirlineCommandHandler)
        {
            _createAirlineCommandHandler = createAirlineCommandHandler;
            _getAirlineByIdQueryHandler = getAirlineByIdQueryHandler;
            _getAirlineQueryHandler = getAirlineQueryHandler;
            _removeAirlineCommandHandler = removeAirlineCommandHandler;
            _updateAirlineCommandHandler = updateAirlineCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> AirlineList()
        {
            var values = await _getAirlineQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAirline(int id)
        {
            var value = await _getAirlineByIdQueryHandler.Handle(new GetAirlineByIdQuery(id));
            return Ok(value);

        }
        [HttpPost]
        public async Task<IActionResult> CreateAirline(CreateAirlineCommand command)
        {
            await _createAirlineCommandHandler.Handle(command);
            return Ok("Airline Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAirline(UpdateAirlineCommand command)
        {
            await _updateAirlineCommandHandler.Handle(command);
            return Ok("Airline Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveAirline(int id)
        {
            await _removeAirlineCommandHandler.Handle(new RemoveAirlineCommand(id));
            return Ok("Airline Silindi");
        }
    }
}
