using BookingApplication.Application.Features.CQRS.Commands.CurrencyCommands;
using BookingApplication.Application.Features.CQRS.Handlers.CurrencyHandlers;
using BookingApplication.Application.Features.CQRS.Queries.CurrencyQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CurrenciesController : ControllerBase
    {
        private readonly CreateCurrencyCommandhandler _createCurrencyCommandhandler;
        private readonly UpdateCurrencyCommandHandler _updateCurrencyCommandHandler;
        private readonly RemoveCurrencyCommandHandler _removeCurrencyCommandHandler;
        private readonly GetCurrencyByIdQueryHandler _getCurrencyByIdQueryHandler;
        private readonly GetCurrencyQueryHandler _getCurrencyQueryHandler;

        public CurrenciesController(CreateCurrencyCommandhandler createCurrencyCommandhandler, UpdateCurrencyCommandHandler updateCurrencyCommandHandler, RemoveCurrencyCommandHandler removeCurrencyCommandHandler, GetCurrencyByIdQueryHandler getCurrencyByIdQueryHandler, GetCurrencyQueryHandler getCurrencyQueryHandler)
        {
            _createCurrencyCommandhandler = createCurrencyCommandhandler;
            _updateCurrencyCommandHandler = updateCurrencyCommandHandler;
            _removeCurrencyCommandHandler = removeCurrencyCommandHandler;
            _getCurrencyByIdQueryHandler = getCurrencyByIdQueryHandler;
            _getCurrencyQueryHandler = getCurrencyQueryHandler;
        }

        [HttpGet]
        public async Task<IActionResult> CurrencyList()
        {
            var values = await _getCurrencyQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCurrency(int id)
        {
            var value = await _getCurrencyByIdQueryHandler.Handle(new GetCurrencyByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCurrency(CreateCurrencyCommand command)
        {
            await _createCurrencyCommandhandler.Handle(command);
            return Ok("Currency eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCurrency(int id)
        {
            await _removeCurrencyCommandHandler.Handle(new RemoveCurrencyCommand(id));
            return Ok("Currency Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCurrency(UpdateCurrencyCommand command)
        {
            await _updateCurrencyCommandHandler.Handle(command);
            return Ok("Currency Güncellendi");
        }


    }
}
