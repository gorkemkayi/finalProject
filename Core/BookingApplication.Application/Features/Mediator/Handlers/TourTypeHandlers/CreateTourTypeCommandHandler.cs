using BookingApplication.Application.Features.Mediator.Commands.TourTypeCommands;
using BookingApplication.Application.Interfaces;
using BookingApplication.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Handlers.TourTypeHandlers
{
    public class CreateTourTypeCommandHandler : IRequestHandler<CreateTourTypeCommand>
    {
        private readonly IRepository<TourType> _repository;

        public CreateTourTypeCommandHandler(IRepository<TourType> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateTourTypeCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new TourType
            {
                Name = request.Name,
            });
        }
    }
}
