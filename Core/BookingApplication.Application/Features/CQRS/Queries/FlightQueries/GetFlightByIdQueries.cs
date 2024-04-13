using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Queries.FlightQueries
{
    public class GetFlightByIdQueries
    {
        public int Id { get; set; }

        public GetFlightByIdQueries(int id)
        {
            Id = id;
        }
    }
}
