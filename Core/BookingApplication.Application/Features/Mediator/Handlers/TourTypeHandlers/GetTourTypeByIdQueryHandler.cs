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
    public class GetTourTypeByIdQueryHandler : IRequestHandler<GetTourTypeByIdQuery, GetTourTypeByIdQueryResult>
    {
        private readonly IRepository<TourType> _repository;

        public GetTourTypeByIdQueryHandler(IRepository<TourType> repository)
        {
            _repository = repository;
        }

        public async Task<GetTourTypeByIdQueryResult> Handle(GetTourTypeByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetTourTypeByIdQueryResult
            {
                Id = values.Id,
                Name = values.Name,
            };
        }
    }
}
