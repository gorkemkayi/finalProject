using BookingApplication.Application.Features.CQRS.Results.HotelResults;
using BookingApplication.Application.Interfaces.Hotelinterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Handlers.HotelHandlers
{
    public class GetHotelQueryHandler
    {
        private readonly IHotelRepository _repository;

        public GetHotelQueryHandler(IHotelRepository repository)
        {
            _repository = repository;
        }

        public List<GetHotelQueryResult> Handle()
        {
            var values = _repository.GetHotelListWithCurrency();
            return values.Select(x => new GetHotelQueryResult
            {
                ID = x.ID,
                Name = x.Name,
                Description = x.Description,
                Stars = x.Stars,
                Rating = x.Rating,
                LocationID = x.LocationID,
                LocationName = x.Location.Name,
                Checkin = x.Checkin,
                Checkout = x.Checkout,
                HotemlAmentities = x.HotemlAmentities,
                Policy = x.Policy,
                Cancellation = x.Cancellation,
                AgeRequirement = x.AgeRequirement,
                Price = x.Price,
                CurrencyID = x.CurrencyID,
                CurrencyName = x.Currency.Name,
                Image = x.Image
            }).ToList();
        }
    }
}
