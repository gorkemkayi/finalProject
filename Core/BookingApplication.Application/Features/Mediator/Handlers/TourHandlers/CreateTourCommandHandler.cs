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
    public class CreateTourCommandHandler : IRequestHandler<CreateTourCommand>
    {
        private readonly IRepository<Tour> _repository;

        public CreateTourCommandHandler(IRepository<Tour> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateTourCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Tour
            {
                Name = request.Name,
                CurrencyId = request.CurrencyId,
                Stars = request.Stars,
                Rating = request.Rating,
                TourAdultPrice = request.TourAdultPrice,
                TourChildPrice = request.TourChildPrice,
                Description = request.Description,
                Policy = request.Policy,
                Location = request.Location,
                TourTypeId = request.TourTypeId,
                Image=request.Image,
            });
        }
    }
}
