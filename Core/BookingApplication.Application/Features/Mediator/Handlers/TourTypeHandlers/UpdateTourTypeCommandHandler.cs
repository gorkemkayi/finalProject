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
    public class UpdateTourTypeCommandHandler : IRequestHandler<UpdateTourTypeCommand>
    {
        private readonly IRepository<TourType> _repository;

        public UpdateTourTypeCommandHandler(IRepository<TourType> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTourTypeCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            values.Name = request.Name;
            await _repository.UpdateAsync(values);
        }
    }
}
