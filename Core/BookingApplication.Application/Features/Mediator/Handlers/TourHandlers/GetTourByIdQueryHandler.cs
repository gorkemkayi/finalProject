using BookingApplication.Application.Features.Mediator.Queries.TourQueries;
using BookingApplication.Application.Features.Mediator.Results.TourResults;
using BookingApplication.Application.Interfaces.TourInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Handlers.TourHandlers
{
    public class GetTourByIdQueryHandler : IRequestHandler<GetTourByIdQuery, GetTourByIdQueryResult>
    {
        private readonly ITourRepository _repository;

        public GetTourByIdQueryHandler(ITourRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetTourByIdQueryResult> Handle(GetTourByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetTourById(request.Id);
            return new GetTourByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name,
                CurrencyId = value.CurrencyId,
                CurrencyName = value.Currency.Name,
                Stars = value.Stars,
                Rating = value.Rating,
                TourAdultPrice = value.TourAdultPrice,
                TourChildPrice = value.TourChildPrice,
                Description = value.Description,
                Policy = value.Policy,
                Location = value.Location,
                TourTypeId = value.TourTypeId,
                TourTypeName = value.TourType.Name,
                Image=value.Image
            };
        }
    }
}
