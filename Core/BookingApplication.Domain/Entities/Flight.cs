using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Domain.Entities
{
    public class Flight
    {
        public int Id { get; set; }
        public int AirlineID { get; set; }
        public Airline Airline { get; set; }
        public int AirportID { get; set; }
        public Airport Airport { get; set; }
        public int AdultSeatPrice { get; set; }
        public int ChildPrice { get; set; }
        public int InfantPrice { get; set; }
        public int Duration { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int Baggage { get; set; }
        public int CabinBaggage { get; set; }
        public int FlightTypeID { get; set; }
        public FlightType FlightType { get; set; }
        public string DepartureCity { get; set; }
        public string LandingCity { get; set; }
        public bool Available { get; set; }
        public List<FlightProcess> FlightProcesses { get; set; }
        public List<FlightReservation> FlightReservations { get; set; }

    }
}
