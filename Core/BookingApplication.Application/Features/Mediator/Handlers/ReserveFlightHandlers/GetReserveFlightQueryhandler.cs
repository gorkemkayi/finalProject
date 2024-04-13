using BookingApplication.Application.Features.Mediator.Queries.ReserveFlightQueries;
using BookingApplication.Application.Features.Mediator.Results.ReserveFlightResults;
using BookingApplication.Application.Interfaces.FlightInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Handlers.ReserveFlightHandlers
{
    public class GetReserveFlightQueryhandler : IRequestHandler<GetReserveFlightQuery, List<GetReserveFlightQueryResult>>
    {
        private readonly IFlightRepository _repository;

        public GetReserveFlightQueryhandler(IFlightRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetReserveFlightQueryResult>> Handle(GetReserveFlightQuery request, CancellationToken cancellationToken)
        {
            var values =await _repository.GetByFilterAsync(x => x.AirportID == request.AirportId && x.Available == true);
            var results= values.Select(x => new GetReserveFlightQueryResult
            {
                FlightId = x.Id,
                AirlineID=x.AirlineID,
                AirlineName=x.Airline.Name,
                AirportID=x.AirportID,
                AirportName=x.Airport.Name,
                AdultSeatPrice=x.AdultSeatPrice,
                ChildPrice=x.ChildPrice, 
                InfantPrice=x.InfantPrice,
                Duration=x.Duration,
                DepartureTime=x.DepartureTime,
                ArrivalTime=x.ArrivalTime,
                Baggage=x.Baggage,
                CabinBaggage=x.CabinBaggage,
                FlightTypeID=x.FlightTypeID,
                FlightTypeName=x.FlightType.Name,
                DepartureCity=x.DepartureCity,
                LandingCity=x.LandingCity,
                AirlineImage=x.Airline.Image,

            }).ToList();
            return results;
        }
    }
}