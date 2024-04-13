using BookingApplication.Application.Features.Mediator.Commands.BlogCategoryCommands;
using BookingApplication.Application.Interfaces;
using BookingApplication.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Handlers.BlogCategoryHandlers
{
    public class RemoveBlogCategoryCommandHandler : IRequestHandler<RemoveBlogCategoryCommand>
    {
        private readonly IRepository<BlogCategory> _repository;

        public RemoveBlogCategoryCommandHandler(IRepository<BlogCategory> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBlogCategoryCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
