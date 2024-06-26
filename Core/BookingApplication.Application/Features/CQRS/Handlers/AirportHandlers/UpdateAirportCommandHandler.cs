﻿using BookingApplication.Application.Features.CQRS.Commands.AirportCommands;
using BookingApplication.Application.Interfaces;
using BookingApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Handlers.AirportHandlers
{
    public class UpdateAirportCommandHandler
    {
        private readonly IRepository<Airport> _repository;

        public UpdateAirportCommandHandler(IRepository<Airport> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAirportCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);
            values.Name = command.Name;
            await _repository.UpdateAsync(values);
        }
    }
}
