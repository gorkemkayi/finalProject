using BookingApplication.Application.Features.CQRS.Queries.FlightQueries;
using BookingApplication.Application.Features.CQRS.Results.FlightResults;
using BookingApplication.Application.Interfaces.FlightInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Handlers.FlightHandlers
{
    public class GetFlightByIdQueryHandler
    {
        private readonly IFlightRepository _repository;

        public GetFlightByIdQueryHandler(IFlightRepository repository)
        {
            _repository = repository;
        }

        public GetFlightByIdQueryResult Handle(GetFlightByIdQueries query)
        {
            var values = _repository.GetFlightById(query.Id);
            return new GetFlightByIdQueryResult
            {
                Id = values.Id,
                AirlineID = values.AirlineID,
                AirlineName = values.Airline.Name,
                AirportID = values.AirportID,
                AirportName = values.Airport.Name,
                AdultSeatPrice = values.AdultSeatPrice,
                ChildPrice = values.ChildPrice,
                InfantPrice = values.InfantPrice,
                Duration = values.Duration,
                DepartureTime = values.DepartureTime,
                ArrivalTime = values.ArrivalTime,
                Baggage = values.Baggage,
                CabinBaggage = values.CabinBaggage,
                FlightTypeID = values.FlightTypeID,
                FlightTypeName = values.FlightType.Name,
                DepartureCity = values.DepartureCity,
                LandingCity = values.LandingCity,
                AirlineImage=values.Airline.Image
            };
        }
    }
}