using BookingApplication.Application.Features.Mediator.Queries.FilterHotelQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FilterHotelsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FilterHotelsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetHotelsByLocation(int locationid)
        {
            GetFilterHotelQuery getFilterHotelQuery = new GetFilterHotelQuery()
            {
                LocationID = locationid
            };
            var values=await _mediator.Send(getFilterHotelQuery);
            return Ok(values);
        }
    }
}
