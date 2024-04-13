using BookingApplication.Application.Features.CQRS.Queries.HotelQueries;
using BookingApplication.Application.Features.CQRS.Results.HotelResults;
using BookingApplication.Application.Interfaces.Hotelinterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Handlers.HotelHandlers
{
    public class GetHotelByIdQueryHandler
    {
        private readonly IHotelRepository _repository;

        public GetHotelByIdQueryHandler(IHotelRepository repository)
        {
            _repository = repository;
        }

        public GetHotelByIdQueryResult Handle(GetHotelByIdQuery query)
        {
            var values = _repository.GetHotelById(query.Id);
            return new GetHotelByIdQueryResult
            {
                ID = values.ID,
                Name = values.Name,
                Description = values.Description,
                Stars = values.Stars,
                Rating = values.Rating,
                LocationID = values.LocationID,
                LocationName=values.Location.Name,
                Checkin = values.Checkin,
                Checkout = values.Checkout,
                HotemlAmentities = values.HotemlAmentities,
                Policy = values.Policy,
                Cancellation = values.Cancellation,
                AgeRequirement = values.AgeRequirement,
                Price = values.Price,
                CurrencyID = values.CurrencyID,
                CurrencyName = values.Currency.Name,
                Image = values.Image

            };
        }
    }
}
