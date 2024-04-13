using BookingApplication.Application.Features.Mediator.Results.TourTypeResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Queries.TourTypeQueries
{
    public class GetTourTypeQuery : IRequest<List<GetTourTypeQueryResult>>
    {

    }
}
