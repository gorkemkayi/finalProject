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
    public class GetBlogCategoryQueryHandler : IRequestHandler<GetBlogCategoryQuery, List<GetBlogCategoryQueryResult>>
    {
        private readonly IRepository<BlogCategory> _repository;

        public GetBlogCategoryQueryHandler(IRepository<BlogCategory> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogCategoryQueryResult>> Handle(GetBlogCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBlogCategoryQueryResult
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
        }
    }
}
