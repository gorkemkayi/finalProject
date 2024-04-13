using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Queries.FlightTypeQueries
{
    public class GetFlightTypeByIdQuery
    {
        public int Id { get; set; }

        public GetFlightTypeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
