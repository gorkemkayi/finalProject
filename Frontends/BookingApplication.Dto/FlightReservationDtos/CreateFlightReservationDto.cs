using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Dto.FlightReservationDtos
{
    public class CreateFlightReservationDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int FlightID { get; set; }
        public int Age { get; set; }
        public string SeatNumber { get; set; }
    }
}
