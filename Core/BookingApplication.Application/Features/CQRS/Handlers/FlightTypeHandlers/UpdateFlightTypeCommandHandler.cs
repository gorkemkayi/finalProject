using BookingApplication.Application.Features.CQRS.Commands.FlightTypeCommands;
using BookingApplication.Application.Interfaces;
using BookingApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Handlers.FlightTypeHandlers
{
    public class UpdateFlightTypeCommandHandler
    {
        private readonly IRepository<FlightType> _repository;

        public UpdateFlightTypeCommandHandler(IRepository<FlightType> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFlightTypeCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            value.Name = command.Name;
            await _repository.UpdateAsync(value);
        }
    }
}
