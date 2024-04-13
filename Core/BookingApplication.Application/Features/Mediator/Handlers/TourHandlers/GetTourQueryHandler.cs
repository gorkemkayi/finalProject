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
    public class GetTourQueryHandler : IRequestHandler<GetTourQuery, List<GetTourQueryResult>>
    {
        private readonly ITourRepository _repository;

        public GetTourQueryHandler(ITourRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTourQueryResult>> Handle(GetTourQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetTourList();
            return values.Select(x => new GetTourQueryResult
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
                Image=x.Image
            }).ToList();
        }
    }
}
