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
    public class RemoveFlightTypeCommandHandler
    {
        private readonly IRepository<FlightType> _repository;

        public RemoveFlightTypeCommandHandler(IRepository<FlightType> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveFlightTypeCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
