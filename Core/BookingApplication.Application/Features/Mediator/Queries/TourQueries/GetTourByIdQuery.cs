using BookingApplication.Application.Features.Mediator.Results.TourResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Queries.TourQueries
{
    public class GetTourByIdQuery : IRequest<GetTourByIdQueryResult>
    {
        public int Id { get; set; }

        public GetTourByIdQuery(int id)
        {
            Id = id;
        }
    }
}
