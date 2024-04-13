using BookingApplication.Application.Features.CQRS.Commands.AirlineCommands;
using BookingApplication.Application.Interfaces;
using BookingApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Handlers.AirlineHandlers
{
    public class CreateAirlineCommandHandler
    {
        private readonly IRepository<Airline> _repository;

        public CreateAirlineCommandHandler(IRepository<Airline> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAirlineCommand command)
        {
            await _repository.CreateAsync(new Airline
            {
                Name = command.Name,
                Image= command.Image
            });

        }
    }
}
