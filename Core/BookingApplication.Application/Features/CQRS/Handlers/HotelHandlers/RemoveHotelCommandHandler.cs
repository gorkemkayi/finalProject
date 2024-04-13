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
    public class RemoveHotelCommandHandler
    {
        private readonly IRepository<Hotel> _repository;

        public RemoveHotelCommandHandler(IRepository<Hotel> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveHotelCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
