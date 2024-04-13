using BookingApplication.Application.Features.Mediator.Commands.TourCommands;
using BookingApplication.Application.Features.Mediator.Queries.TourQueries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebApi.Controllers
{    
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ToursController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ToursController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> TourList()
        {
            var values = await _mediator.Send(new GetTourQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTour(int id)
        {
            var value = await _mediator.Send(new GetTourByIdQuery(id));
            return Ok(value);
        }
        [HttpGet]
        public async Task<IActionResult> GetPopularTours()
        {
            var values = await _mediator.Send(new GetPopularToursQuery());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTour(CreateTourCommand command)
        {
            await _mediator.Send(command);
            return Ok("Tour oluşturuldu");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTour(UpdateTourCommand command)
        {
            await _mediator.Send(command);
            return Ok("Tour Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveTour(int id)
        {
            await _mediator.Send(new RemoveTourCommand(id));
            return Ok("Tour silindi");
        }
    }
}
