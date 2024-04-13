using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Dto.FlightReservationDtos
{
    public class FilterReservationFlightDto
    {
        public int FlightId { get; set; }
        public int AirlineID { get; set; }
        public string AirlineName { get; set; }
        public int AirportID { get; set; }
        public string AirportName { get; set; }
        public int AdultSeatPrice { get; set; }
        public int ChildPrice { get; set; }
        public int InfantPrice { get; set; }
        public int Duration { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int Baggage { get; set; }
        public int CabinBaggage { get; set; }
        public int FlightTypeID { get; set; }
        public string FlightTypeName { get; set; }
        public string DepartureCity { get; set; }
        public string LandingCity { get; set; }
        public string AirlineImage { get; set; }

    }
}
