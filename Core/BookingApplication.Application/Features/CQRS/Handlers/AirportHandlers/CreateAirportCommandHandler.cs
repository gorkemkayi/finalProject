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
    public class CreateAirportCommandHandler
    {
        private readonly IRepository<Airport> _repository;

        public CreateAirportCommandHandler(IRepository<Airport> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAirportCommand command)
        {
            await _repository.CreateAsync(new Airport
            {
                Name = command.Name,
            });
        }
    }
}
