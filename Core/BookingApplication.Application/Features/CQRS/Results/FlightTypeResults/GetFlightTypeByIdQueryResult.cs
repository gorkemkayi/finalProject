using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Results.FlightTypeResults
{
    public class GetFlightTypeByIdQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
