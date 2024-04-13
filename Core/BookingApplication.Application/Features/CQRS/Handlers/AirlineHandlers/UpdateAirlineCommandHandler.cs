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
    public class UpdateAirlineCommandHandler
    {
        private readonly IRepository<Airline> _repository;

        public UpdateAirlineCommandHandler(IRepository<Airline> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAirlineCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);
            values.Name = command.Name;
            values.Image = command.Image;
            await _repository.UpdateAsync(values);
        }
    }
}
