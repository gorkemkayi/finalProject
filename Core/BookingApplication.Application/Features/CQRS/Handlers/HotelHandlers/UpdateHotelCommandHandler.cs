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
    public class UpdateHotelCommandHandler
    {
        private readonly IRepository<Hotel> _repository;

        public UpdateHotelCommandHandler(IRepository<Hotel> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateHotelCommand command)
        {
            var values = await _repository.GetByIdAsync(command.ID);
            values.Name = command.Name;
            values.Description = command.Description;
            values.Stars = command.Stars;
            values.Rating = command.Rating;
            //values.LocationID = command.Location;
            values.LocationID = command.LocationID;
            values.Checkin = command.Checkin;
            values.Checkout = command.Checkout;
            values.HotemlAmentities = command.HotemlAmentities;
            values.Policy = command.Policy;
            values.Cancellation = command.Cancellation;
            values.AgeRequirement = command.AgeRequirement;
            values.Price = command.Price;
            values.CurrencyID = command.CurrencyID;
            values.Image = command.Image;
            await _repository.UpdateAsync(values);

        }
    }
}
