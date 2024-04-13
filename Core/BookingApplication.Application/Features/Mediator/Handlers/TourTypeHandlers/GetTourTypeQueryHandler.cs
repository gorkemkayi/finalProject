using BookingApplication.Application.Features.Mediator.Queries.TourTypeQueries;
using BookingApplication.Application.Features.Mediator.Results.TourTypeResults;
using BookingApplication.Application.Interfaces;
using BookingApplication.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Handlers.TourTypeHandlers
{
    public class GetTourTypeQueryHandler : IRequestHandler<GetTourTypeQuery, List<GetTourTypeQueryResult>>
    {
        private readonly IRepository<TourType> _repository;

        public GetTourTypeQueryHandler(IRepository<TourType> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTourTypeQueryResult>> Handle(GetTourTypeQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetTourTypeQueryResult
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
        }
    }
}
