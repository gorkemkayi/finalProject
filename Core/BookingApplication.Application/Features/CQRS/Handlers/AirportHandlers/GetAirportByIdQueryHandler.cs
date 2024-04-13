using BookingApplication.Application.Features.CQRS.Queries.AirportQueries;
using BookingApplication.Application.Features.CQRS.Results.AirportResults;
using BookingApplication.Application.Interfaces;
using BookingApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Handlers.AirportHandlers
{
    public class GetAirportByIdQueryHandler
    {
        private readonly IRepository<Airport> _repository;

        public GetAirportByIdQueryHandler(IRepository<Airport> repository)
        {
            _repository = repository;
        }

        public async Task<GetAirportByIdQueryResult> Handle(GetAirportByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);

            return new GetAirportByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name,
            };
        }
    }
}
