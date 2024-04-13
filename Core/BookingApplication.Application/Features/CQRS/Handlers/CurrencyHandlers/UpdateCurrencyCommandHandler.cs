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
    public class UpdateCurrencyCommandHandler
    {
        private readonly IRepository<Currency> _repository;

        public UpdateCurrencyCommandHandler(IRepository<Currency> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCurrencyCommand command)
        {
            var values = await _repository.GetByIdAsync(command.ID);
            values.Name = command.Name;
            await _repository.UpdateAsync(values);
        }
    }
}
