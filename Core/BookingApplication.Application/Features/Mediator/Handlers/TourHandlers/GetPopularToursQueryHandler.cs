using BookingApplication.Application.Features.Mediator.Queries.TourQueries;
using BookingApplication.Application.Features.Mediator.Results.TourResults;
using BookingApplication.Application.Interfaces.BlogInterfaces;
using BookingApplication.Application.Interfaces.TourInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Handlers.TourHandlers
{
    public class GetPopularToursQueryHandler : IRequestHandler<GetPopularToursQuery, List<GetPopularToursQueryResult>>
    {
        private readonly ITourRepository _repository;

        public GetPopularToursQueryHandler(ITourRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetPopularToursQueryResult>> Handle(GetPopularToursQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetPopularTours();
            return values.Select(x => new GetPopularToursQueryResult
            {
                Id = x.Id,
                Name = x.Name,
                CurrencyId = x.CurrencyId,
                CurrencyName = x.Currency.Name,
                Stars = x.Stars,
                Rating = x.Rating,
                TourAdultPrice = x.TourAdultPrice,
                TourChildPrice = x.TourChildPrice,
                Description = x.Description,
                Policy = x.Policy,
                Location = x.Location,
                TourTypeId = x.TourTypeId,
                TourTypeName = x.TourType.Name,
                Image= x.Image,
            }).ToList();
        }
    }
}