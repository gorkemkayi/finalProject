using BookingApplication.Application.Features.CQRS.Commands.CurrencyCommands;
using BookingApplication.Application.Interfaces;
using BookingApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Handlers.CurrencyHandlers
{
    public class CreateCurrencyCommandhandler
    {
        private readonly IRepository<Currency> _repository;

        public CreateCurrencyCommandhandler(IRepository<Currency> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCurrencyCommand command)
        {
            await _repository.CreateAsync(new Currency
            {
                Name = command.Name,
            });
        }

    }
}
