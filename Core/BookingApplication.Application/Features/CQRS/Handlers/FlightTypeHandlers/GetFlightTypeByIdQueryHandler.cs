using BookingApplication.Application.Features.CQRS.Queries.FlightTypeQueries;
using BookingApplication.Application.Features.CQRS.Results.FlightTypeResults;
using BookingApplication.Application.Interfaces;
using BookingApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Handlers.FlightTypeHandlers
{
    public class GetFlightTypeByIdQueryHandler
    {
        private readonly IRepository<FlightType> _repository;

        public GetFlightTypeByIdQueryHandler(IRepository<FlightType> repository)
        {
            _repository = repository;
        }

        public async Task<GetFlightTypeByIdQueryResult> Handle(GetFlightTypeByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetFlightTypeByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name,
            };
        }
    }
}
