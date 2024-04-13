using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Results.AirlineResults
{
    public class GetAirlineQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

    }
}
