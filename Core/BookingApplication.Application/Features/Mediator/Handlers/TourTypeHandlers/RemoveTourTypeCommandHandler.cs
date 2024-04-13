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
    public class RemoveTourTypeCommandHandler : IRequestHandler<RemoveTourTypeCommand>
    {
        private readonly IRepository<TourType> _repository;

        public RemoveTourTypeCommandHandler(IRepository<TourType> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveTourTypeCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
