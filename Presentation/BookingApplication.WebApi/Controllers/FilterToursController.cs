using BookingApplication.Application.Features.Mediator.Queries.FilterTourQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FilterToursController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FilterToursController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetToursByTourtype(int tourtypeid)
        {
            GetFilterTourQuery getFilterTourQuery = new GetFilterTourQuery()
            {
                TourTypeId = tourtypeid
            };
            var values=await _mediator.Send(getFilterTourQuery);
            return Ok(values);
        }
    }
}
