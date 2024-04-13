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
    public class RemoveAirlineCommandHandler
    {
        private readonly IRepository<Airline> _repository;

        public RemoveAirlineCommandHandler(IRepository<Airline> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAirlineCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
