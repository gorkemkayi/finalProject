using BookingApplication.Application.Features.Mediator.Commands.TourTypeCommands;
using BookingApplication.Application.Features.Mediator.Queries.TourTypeQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TourTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TourTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> TourTypeList()
        {
            var values = await _mediator.Send(new GetTourTypeQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTourType(int id)
        {
            var value = await _mediator.Send(new GetTourTypeByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTourType(CreateTourTypeCommand command)
        {
            await _mediator.Send(command);
            return Ok("TourType Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveTourTpe(int id)
        {
            await _mediator.Send(new RemoveTourTypeCommand(id));
            return Ok("TourType Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTourType(UpdateTourTypeCommand command)
        {
            await _mediator.Send(command);
            return Ok("TourType Güncellendi");
        }
    }
}
