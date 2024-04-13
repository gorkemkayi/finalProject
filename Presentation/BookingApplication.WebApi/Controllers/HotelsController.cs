using BookingApplication.Application.Features.CQRS.Commands.HotelCommands;
using BookingApplication.Application.Features.CQRS.Handlers.HotelHandlers;
using BookingApplication.Application.Features.CQRS.Queries.HotelQueries;
using BookingApplication.Application.Features.CQRS.Results.HotelResults;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly CreateHotelCommandHandler _createHotelCommandHandler;
        private readonly GetHotelByIdQueryHandler _getHotelByIdQueryHandler;
        private readonly GetHotelQueryHandler _getHotelQueryHandler;
        private readonly RemoveHotelCommandHandler _removeHotelCommandHandler;
        private readonly UpdateHotelCommandHandler _updateHotelCommandHandler;
        private readonly Get5HotelQueryHandler _get5HotelQueryHandler;

        public HotelsController(CreateHotelCommandHandler createHotelCommandHandler, GetHotelByIdQueryHandler getHotelByIdQueryHandler, GetHotelQueryHandler getHotelQueryHandler, RemoveHotelCommandHandler removeHotelCommandHandler, UpdateHotelCommandHandler updateHotelCommandHandler, Get5HotelQueryHandler get5HotelQueryHandler)
        {
            _createHotelCommandHandler = createHotelCommandHandler;
            _getHotelByIdQueryHandler = getHotelByIdQueryHandler;
            _getHotelQueryHandler = getHotelQueryHandler;
            _removeHotelCommandHandler = removeHotelCommandHandler;
            _updateHotelCommandHandler = updateHotelCommandHandler;
            _get5HotelQueryHandler = get5HotelQueryHandler;
        }

        [HttpGet]
        public IActionResult HotelList()
        {
            var values = _getHotelQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet]
        public IActionResult Get5Hotel()
        {
            var values = _get5HotelQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public ActionResult GetHotel(int id)
        {
            var value = _getHotelByIdQueryHandler.Handle(new GetHotelByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHotel(CreateHotelCommand command)
        {
            await _createHotelCommandHandler.Handle(command);
            return Ok("Otel Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveHotel(int id)
        {
            await _removeHotelCommandHandler.Handle(new RemoveHotelCommand(id));
            return Ok("Otel Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHotel(UpdateHotelCommand command)
        {
            await _updateHotelCommandHandler.Handle(command);
            return Ok("Otel Güncellendi");
        }

    }
}
