using BookingApplication.Application.Features.CQRS.Results.HotelResults;
using BookingApplication.Application.Interfaces.Hotelinterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Handlers.HotelHandlers
{
    public class Get5HotelQueryHandler
    {
        private readonly IHotelRepository _repository;

        public Get5HotelQueryHandler(IHotelRepository repository)
        {
            _repository = repository;
        }

        public List<Get5HotelQueryResult> Handle()
        {
            var values = _repository.Get5Hotel();
            return values.Select(x=>new Get5HotelQueryResult
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
                Image = x.Image
            }).ToList();
        }
    }
}
