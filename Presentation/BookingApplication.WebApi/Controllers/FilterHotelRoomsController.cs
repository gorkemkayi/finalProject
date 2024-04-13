using BookingApplication.Application.Features.Mediator.Queries.FilterHotelRoomQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FilterHotelRoomsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FilterHotelRoomsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetHotelRoomsByHotelID(int hotelid)
        {
            GetFilterHotelRoomQuery getFilterHotelRoomQuery = new GetFilterHotelRoomQuery()
            {
                HotelID = hotelid
            };
            var values = await _mediator.Send(getFilterHotelRoomQuery);
            return Ok(values);
        }
    }
}
