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
    public class CreateBlogCategoryCommandHandler : IRequestHandler<CreateBlogCategoryCommand>
    {
        private readonly IRepository<BlogCategory> _repository;

        public CreateBlogCategoryCommandHandler(IRepository<BlogCategory> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBlogCategoryCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new BlogCategory
            {
                Name = request.Name,
            });
        }
    }
}
