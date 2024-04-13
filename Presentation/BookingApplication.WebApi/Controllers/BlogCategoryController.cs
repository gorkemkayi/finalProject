using BookingApplication.Application.Features.Mediator.Commands.BlogCategoryCommands;
using BookingApplication.Application.Features.Mediator.Queries.BlogCategoryQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BlogCategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogCategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> BlogCategoryList()
        {
            var values = await _mediator.Send(new GetBlogCategoryQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogCategory(int id)
        {
            var value = await _mediator.Send(new GetBlogCategoryByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlogCategory(CreateBlogCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog Category Eklenndi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBlogCategory(UpdateBlogCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog Category Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveBlogCategory(int id)
        {
            await _mediator.Send(new RemoveBlogCategoryCommand(id));
            return Ok("Blog Category Silindi");
        }
    }
}
