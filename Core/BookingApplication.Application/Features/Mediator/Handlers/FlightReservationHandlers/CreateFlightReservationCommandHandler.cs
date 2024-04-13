using BookingApplication.Application.Features.CQRS.Commands.FlightCommands;
using BookingApplication.Application.Features.Mediator.Commands.FlightReservationCommands;
using BookingApplication.Application.Interfaces;
using BookingApplication.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Handlers.FlightReservationHandlers
{
    public class CreateFlightReservationCommandHandler : IRequestHandler<CreateFlightReservationCommand>
    {
        private readonly IRepository<FlightReservation> _repository;

        public CreateFlightReservationCommandHandler(IRepository<FlightReservation> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateFlightReservationCommand request, CancellationToken cancellationToken)
        {
            var allFlightReservations = await _repository.GetAllAsync();
            var existingFlightReservation=allFlightReservations.Where(x=>x.FlightID==request.FlightID && x.SeatNumber==request.SeatNumber).FirstOrDefault();
            if (existingFlightReservation!=null)
            {
                throw new Exception("oda rezerve edilmiş");
            }
            
            await _repository.CreateAsync(new FlightReservation
            {
                Name = request.Name,
                Surname = request.Surname,
                Email = request.Email,
                Phone = request.Phone,
                FlightID = request.FlightID,
                Age = request.Age,
                SeatNumber=request.SeatNumber,
                Status="Reserved"

            });
        }
    }
}
