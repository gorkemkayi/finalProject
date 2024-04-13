﻿using BookingApplication.Application.Features.CQRS.Results.FlightResults;
using BookingApplication.Application.Interfaces.FlightInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Handlers.FlightHandlers
{
    public class GetFlightQueryHandler
    {
        private readonly IFlightRepository _repository;

        public GetFlightQueryHandler(IFlightRepository repository)
        {
            _repository = repository;
        }

        public List<GetFlightQueryResults> Handle()
        {
            var values = _repository.GetFlightList();
            return values.Select(x => new GetFlightQueryResults
            {
                Id = x.Id,
                AirlineID = x.AirlineID,
                AirlineName = x.Airline.Name,
                AirportID = x.AirportID,
                AirportName = x.Airport.Name,
                AdultSeatPrice = x.AdultSeatPrice,
                ChildPrice = x.ChildPrice,
                InfantPrice = x.InfantPrice,
                Duration = x.Duration,
                DepartureTime = x.DepartureTime,
                ArrivalTime = x.ArrivalTime,
                Baggage = x.Baggage,
                CabinBaggage = x.CabinBaggage,
                FlightTypeID = x.FlightTypeID,
                FlightTypeName = x.FlightType.Name,
                DepartureCity = x.DepartureCity,
                LandingCity = x.LandingCity,
                AirlineImage=x.Airline.Image
            }).ToList();
        }
    }
}
