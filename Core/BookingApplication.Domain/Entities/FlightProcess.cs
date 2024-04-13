using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Domain.Entities
{
    public class FlightProcess
    {
        public int FlightProcessID { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
