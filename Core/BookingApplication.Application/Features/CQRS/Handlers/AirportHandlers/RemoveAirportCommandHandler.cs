using BookingApplication.Application.Features.CQRS.Commands.AirportCommands;
using BookingApplication.Application.Interfaces;
using BookingApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Handlers.AirportHandlers
{
    public class RemoveAirportCommandHandler
    {
        private readonly IRepository<Airport> _repository;

        public RemoveAirportCommandHandler(IRepository<Airport> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAirportCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
