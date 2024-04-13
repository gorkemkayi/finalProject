using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Queries.AirportQueries
{
    public class GetAirportByIdQuery
    {
        public int Id { get; set; }

        public GetAirportByIdQuery(int id)
        {
            Id = id;
        }
    }
}
