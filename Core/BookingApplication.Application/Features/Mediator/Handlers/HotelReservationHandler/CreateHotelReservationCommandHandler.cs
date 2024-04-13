using BookingApplication.Application.Features.Mediator.Commands.HotelReservationCommands;
using BookingApplication.Application.Interfaces;
using BookingApplication.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Handlers.HotelReservationHandler
{
    public class CreateHotelReservationCommandHandler : IRequestHandler<CreateHotelReservationCommand>
    {
        private readonly IRepository<HotelReservation> _repository;

        public CreateHotelReservationCommandHandler(IRepository<HotelReservation> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateHotelReservationCommand request, CancellationToken cancellationToken)
        {
            var allreservation = await _repository.GetAllAsync();
            var existingReservation=allreservation.Where(x=>x.HotelRoomId == request.HotelRoomId&& x.CheckInDate <= request.CheckOutDate && x.CheckOutDate >= request.CheckInDate).FirstOrDefault();
            if (existingReservation!=null)
            {
                throw new Exception("oda rezerve edilmiş");
            }
            await _repository.CreateAsync(new HotelReservation
            {
                //RoomNumber = request.RoomNumber,
                HotelRoomId =request.HotelRoomId,
                CheckInDate = request.CheckInDate,
                CheckOutDate = request.CheckOutDate,
                Status = "Reserved"
            });
        }
    }
}
