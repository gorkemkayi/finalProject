using BookingApplication.Application.Features.Mediator.Queries.FilterHotelQueries;
using BookingApplication.Application.Features.Mediator.Results.FilterHotelResults;
using BookingApplication.Application.Interfaces.Hotelinterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Handlers.FilterHotelHandlers
{
    public class GetFilterHotelQueryHandler : IRequestHandler<GetFilterHotelQuery, List<GetFilterHotelQueryResult>>
    {
        private readonly IHotelRepository _repository;

        public GetFilterHotelQueryHandler(IHotelRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFilterHotelQueryResult>> Handle(GetFilterHotelQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByFilterAsync(x => x.LocationID == request.LocationID);
            var results = values.Select(x => new GetFilterHotelQueryResult
            {
                ID = x.ID,
                Name = x.Name,
                Description = x.Description,
                Stars = x.Stars,
                Rating = x.Rating,
                LocationID = x.LocationID,
                LocationName=x.Location.Name,
                Checkin = x.Checkin,
                Checkout = x.Checkout,
                HotemlAmentities = x.HotemlAmentities,
                Policy = x.Policy,
                Cancellation = x.Cancellation,
                AgeRequirement = x.AgeRequirement,
                Price = x.Price,
                CurrencyID = x.CurrencyID,
                CurrencyName = x.Currency.Name,
                Image = x.Image,
            }).ToList();
            return results;
        }
    }
}

