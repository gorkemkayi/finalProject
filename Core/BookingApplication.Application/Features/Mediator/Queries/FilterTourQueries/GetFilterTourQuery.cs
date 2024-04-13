using BookingApplication.Application.Features.Mediator.Results.FilterTourResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Queries.FilterTourQueries
{
    public class GetFilterTourQuery:IRequest<List<GetFilterTourQueryResult>>
    {
        public int TourTypeId { get; set; }
    }
}
