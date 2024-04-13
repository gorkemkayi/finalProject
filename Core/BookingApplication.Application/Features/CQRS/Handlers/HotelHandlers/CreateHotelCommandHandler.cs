using BookingApplication.Application.Features.CQRS.Commands.HotelCommands;
using BookingApplication.Application.Interfaces;
using BookingApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Handlers.HotelHandlers
{
    public class CreateHotelCommandHandler
    {
        private readonly IRepository<Hotel> _repository;

        public CreateHotelCommandHandler(IRepository<Hotel> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateHotelCommand command)
        {
            await _repository.CreateAsync(new Hotel
            {
                AgeRequirement = command.AgeRequirement,
                Cancellation = command.Cancellation,
                Checkin = command.Checkin,
                Checkout = command.Checkout,
                Description = command.Description,
                CurrencyID = command.CurrencyID,
                HotemlAmentities = command.HotemlAmentities,
                Image = command.Image,
                LocationID = command.LocationID,
                Name = command.Name,
                Policy = command.Policy,
                Price = command.Price,
                Rating = command.Rating,
                Stars = command.Stars,
            });
        }
    }
}
