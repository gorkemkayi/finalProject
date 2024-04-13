using BookingApplication.Application.Features.CQRS.Queries.AirlineQueries;
using BookingApplication.Application.Features.CQRS.Results.AirlineResults;
using BookingApplication.Application.Interfaces;
using BookingApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Handlers.AirlineHandlers
{
    public class GetAirlineByIdQueryHandler
    {
        private readonly IRepository<Airline> _repository;

        public GetAirlineByIdQueryHandler(IRepository<Airline> repository)
        {
            _repository = repository;
        }

        public async Task<GetAirlineByIdQueryResult> Handle(GetAirlineByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetAirlineByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name,
                Image=value.Image
            };
        }
    }
}
