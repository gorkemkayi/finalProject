using BookingApplication.Application.Features.Mediator.Results.ReserveFlightResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Queries.ReserveFlightQueries
{
    public class GetReserveFlightQuery:IRequest<List<GetReserveFlightQueryResult>>
    {
        public int AirportId { get; set; }
        public bool Available { get; set; }
    }
}
