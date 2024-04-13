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
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<GetBlogQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetBlogQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogQueryResult>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetBlogList();
            return values.Select(x => new GetBlogQueryResult
            {
                Id = x.Id,
                Image = x.Image,
                Title = x.Title,
                Date = x.Date,
                Desc = x.Desc,
                BlogCategoryId = x.BlogCategoryId,
                BlogCategoryName = x.BlogCategory.Name
            }).ToList();
        }
    }
}
