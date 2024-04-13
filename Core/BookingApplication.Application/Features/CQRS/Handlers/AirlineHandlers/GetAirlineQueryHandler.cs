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
    public class GetAirlineQueryHandler
    {
        private readonly IRepository<Airline> _repository;

        public GetAirlineQueryHandler(IRepository<Airline> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAirlineQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAirlineQueryResult()
            {
                Id = x.Id,
                Name = x.Name,
                Image=x.Image
            }).ToList();
        }
    }
}
