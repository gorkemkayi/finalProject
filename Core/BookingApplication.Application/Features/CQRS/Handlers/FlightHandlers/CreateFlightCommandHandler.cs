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
    public class CreateFlightCommandHandler
    {
        private readonly IRepository<Flight> _repository;

        public CreateFlightCommandHandler(IRepository<Flight> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateFlightCommand command)
        {
            await _repository.CreateAsync(new Flight
            {
                AirlineID = command.AirlineID,
                AirportID = command.AirportID,
                AdultSeatPrice = command.AdultSeatPrice,
                ChildPrice = command.ChildPrice,
                InfantPrice = command.InfantPrice,
                Duration = command.Duration,
                DepartureTime = command.DepartureTime,
                ArrivalTime = command.ArrivalTime,
                Baggage = command.Baggage,
                CabinBaggage = command.CabinBaggage,
                FlightTypeID = command.FlightTypeID,
                DepartureCity = command.DepartureCity,
                LandingCity = command.LandingCity,
            });
        }
    }
}