using BookingApplication.Application.Features.Mediator.Commands.AppUserCommands;
using BookingApplication.Application.Tools;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RegistersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RegistersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateAppUserCommand command)
        {
            await _mediator.Send(command);
            var data = new {Message="Kullanıcı Oluşturuldu" };
            return Ok(data);
        }
    }
}
