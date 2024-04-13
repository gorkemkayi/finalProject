using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Domain.Entities
{
    public class FlightReservation
    {
        public int FlightReservationID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int FlightID { get; set; }
        public Flight Flight { get; set; }
        public int Age { get; set; }
        public string Status { get; set; }
        public string SeatNumber { get; set; }

    }
}
