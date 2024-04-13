using BookingApplication.Application.Features.CQRS.Commands.FlightCommands;
using BookingApplication.Application.Interfaces;
using BookingApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Handlers.FlightHandlers
{
    public class RemoveFlightCommandHandler
    {
        private readonly IRepository<Flight> _repository;

        public RemoveFlightCommandHandler(IRepository<Flight> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveFlightCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
