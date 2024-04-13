using BookingApplication.Application.Features.Mediator.Results.BlogCategoryResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Queries.BlogCategoryQueries
{
    public class GetBlogCategoryQuery : IRequest<List<GetBlogCategoryQueryResult>>
    {
    }
}
