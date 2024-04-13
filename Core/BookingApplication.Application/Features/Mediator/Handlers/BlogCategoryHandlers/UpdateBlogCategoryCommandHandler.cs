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
    public class UpdateBlogCategoryCommandHandler : IRequestHandler<UpdateBlogCategoryCommand>
    {
        private readonly IRepository<BlogCategory> _repository;

        public UpdateBlogCategoryCommandHandler(IRepository<BlogCategory> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCategoryCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            values.Name = request.Name;
            await _repository.UpdateAsync(values);
        }
    }
}
