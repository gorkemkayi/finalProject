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
    public class UpdateFlightCommandHandler
    {
        private readonly IRepository<Flight> _repository;

        public UpdateFlightCommandHandler(IRepository<Flight> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFlightCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);
            values.AirlineID = command.AirlineID;
            values.AirportID = command.AirportID;
            values.AdultSeatPrice = command.AdultSeatPrice;
            values.ChildPrice = command.ChildPrice;
            values.InfantPrice = command.InfantPrice;
            values.Duration = command.Duration;
            values.DepartureTime = command.DepartureTime;
            values.ArrivalTime = command.ArrivalTime;
            values.Baggage = command.Baggage;
            values.CabinBaggage = command.CabinBaggage;
            values.FlightTypeID = command.FlightTypeID;
            values.DepartureCity = command.DepartureCity;
            values.LandingCity = command.LandingCity;
            await _repository.UpdateAsync(values);
        }
    }
}