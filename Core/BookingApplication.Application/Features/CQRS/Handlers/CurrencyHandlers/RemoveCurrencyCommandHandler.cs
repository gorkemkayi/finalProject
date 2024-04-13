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
    public class RemoveCurrencyCommandHandler
    {
        private readonly IRepository<Currency> _repository;

        public RemoveCurrencyCommandHandler(IRepository<Currency> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveCurrencyCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
