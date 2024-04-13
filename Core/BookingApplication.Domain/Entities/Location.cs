using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Domain.Entities
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Hotel> Hotels { get; set; }
    }
}
