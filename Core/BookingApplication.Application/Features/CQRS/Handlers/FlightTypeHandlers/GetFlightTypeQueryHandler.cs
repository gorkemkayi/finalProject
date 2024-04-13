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
    public class GetFlightTypeQueryHandler
    {
        private readonly IRepository<FlightType> _repository;

        public GetFlightTypeQueryHandler(IRepository<FlightType> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFlightTypeQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFlightTypeQueryResult
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
        }
    }
}
