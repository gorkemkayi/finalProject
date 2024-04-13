using BookingApplication.Application.Features.Mediator.Queries.FilterTourQueries;
using BookingApplication.Application.Features.Mediator.Results.FilterTourResults;
using BookingApplication.Application.Interfaces.TourInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Handlers.FilterTourHandlers
{
    public class GetFilterTourQueryHandler : IRequestHandler<GetFilterTourQuery, List<GetFilterTourQueryResult>>
    {
        private ITourRepository _repository;

        public GetFilterTourQueryHandler(ITourRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFilterTourQueryResult>> Handle(GetFilterTourQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByFilterAsync(x => x.TourTypeId == request.TourTypeId);
            var results=values.Select(x=> new GetFilterTourQueryResult
            {
                Id = x.Id,
                Name = x.Name,
                CurrencyId = x.CurrencyId,
                CurrencyName=x.Currency.Name,
                Stars = x.Stars,
                Rating = x.Rating,
                TourAdultPrice = x.TourAdultPrice,
                TourChildPrice = x.TourChildPrice,
                Description = x.Description,
                Policy = x.Policy,
                Location = x.Location,
                TourTypeId = x.TourTypeId,
                TourTypeName=x.TourType.Name,
                Image=x.Image,
            }).ToList();
            return results;
        }
    }
}