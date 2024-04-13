using BookingApplication.Application.Features.Mediator.Queries.BlogCategoryQueries;
using BookingApplication.Application.Features.Mediator.Results.BlogCategoryResults;
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
    public class GetBlogCategoryByIdQueryHandler : IRequestHandler<GetBlogCategoryByIdQuery, GetBlogCategoryByIdQueryResult>
    {
        private readonly IRepository<BlogCategory> _repository;

        public GetBlogCategoryByIdQueryHandler(IRepository<BlogCategory> repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogCategoryByIdQueryResult> Handle(GetBlogCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetBlogCategoryByIdQueryResult
            {
                Id = values.Id,
                Name = values.Name,
            };
        }
    }
}
