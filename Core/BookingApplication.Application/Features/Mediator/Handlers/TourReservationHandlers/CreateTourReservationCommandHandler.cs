using BookingApplication.Application.Features.Mediator.Commands.TourReservationCommands;
using BookingApplication.Application.Interfaces;
using BookingApplication.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Handlers.TourReservationHandlers
{
    public class CreateTourReservationCommandHandler : IRequestHandler<CreateTourReservationCommand>
    {
        private readonly IRepository<TourReservation> _repository;

        public CreateTourReservationCommandHandler(IRepository<TourReservation> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateTourReservationCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new TourReservation
            {
                TourID = request.TourID,
                Person = request.Person

            });
        }
    }
}
