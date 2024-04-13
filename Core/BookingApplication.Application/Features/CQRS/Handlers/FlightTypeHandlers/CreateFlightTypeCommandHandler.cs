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
    public class CreateFlightTypeCommandHandler
    {
        private readonly IRepository<FlightType> _repository;

        public CreateFlightTypeCommandHandler(IRepository<FlightType> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateFlightTypeCommand command)
        {
            await _repository.CreateAsync(new FlightType
            {
                Name = command.Name,
            });
        }
    }
}
