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
    public class GetAirportQueryHandler
    {
        private readonly IRepository<Airport> _repository;

        public GetAirportQueryHandler(IRepository<Airport> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAirportQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAirportQueryResult
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
        }
    }
}
