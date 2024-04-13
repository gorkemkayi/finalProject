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
    public class UpdateTourCommandHandler : IRequestHandler<UpdateTourCommand>
    {
        private readonly IRepository<Tour> _repository;

        public UpdateTourCommandHandler(IRepository<Tour> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTourCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            values.Name = request.Name;
            values.CurrencyId = request.CurrencyId;
            values.Stars = request.Stars;
            values.Rating = request.Rating;
            values.TourAdultPrice = request.TourAdultPrice;
            values.TourChildPrice = request.TourChildPrice;
            values.Description = request.Description;
            values.Policy = request.Policy;
            values.Location = request.Location;
            values.TourTypeId = request.TourTypeId;
            values.Image=request.Image;
            await _repository.UpdateAsync(values);
        }
    }
}
