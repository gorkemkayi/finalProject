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
    public class GetLocationByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, GetLocationByIdQueryResult>
    {
        private readonly ILocationRepository _repository;

        public GetLocationByIdQueryHandler(ILocationRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
            var value= await _repository.GetLocationByID(request.Id);
            return new GetLocationByIdQueryResult
            {
                ID = value.ID,
                Name = value.Name,
            };
        }
    }
}
