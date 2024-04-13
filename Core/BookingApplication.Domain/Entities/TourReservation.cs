using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Domain.Entities
{
    public class TourReservation
    {
        public int ID { get; set; }
        public int TourID { get; set; }
        public Tour Tour { get; set; }
        //public decimal totalPrice { get; set; }
        public int Person { get; set; }
    }
}
