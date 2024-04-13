using BookingApplication.Application.Features.Mediator.Queries.BlogQueries;
using BookingApplication.Application.Features.Mediator.Results.BlogResults;
using BookingApplication.Application.Interfaces.BlogInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
    {
        private readonly IBlogRepository _repository;

        public GetBlogByIdQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetBlogById(request.Id);
            return new GetBlogByIdQueryResult
            {
                Id = value.Id,
                Image = value.Image,
                Title = value.Title,
                Date = value.Date,
                Desc = value.Desc,
                BlogCategoryId = value.BlogCategoryId,
                BlogCategoryName = value.BlogCategory.Name
            };
        }
    }
}
