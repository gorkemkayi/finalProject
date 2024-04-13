using BookingApplication.Application.Features.Mediator.Queries.LocationQueries;
using BookingApplication.Application.Features.Mediator.Results.LocationResults;
using BookingApplication.Application.Interfaces.LocationInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class GetLocationQueryHandler : IRequestHandler<GetLocationQuery, List<GetLocationQueryResult>>
    {
        private readonly ILocationRepository _repository;

        public GetLocationQueryHandler(ILocationRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetLocationList();
            return values.Select(x => new GetLocationQueryResult
            {
                ID = x.ID,
                Name = x.Name,
            }).ToList();
            
        }
    }
}
