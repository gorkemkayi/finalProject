using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Queries.AirlineQueries
{
    public class GetAirlineByIdQuery
    {
        public int Id { get; set; }

        public GetAirlineByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
