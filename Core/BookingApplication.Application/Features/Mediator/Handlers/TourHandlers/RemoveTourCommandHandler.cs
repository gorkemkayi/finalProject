using BookingApplication.Application.Features.Mediator.Commands.TourCommands;
using BookingApplication.Application.Interfaces;
using BookingApplication.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Handlers.TourHandlers
{
    public class RemoveTourCommandHandler : IRequestHandler<RemoveTourCommand>
    {
        private readonly IRepository<Tour> _repository;

        public RemoveTourCommandHandler(IRepository<Tour> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveTourCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
