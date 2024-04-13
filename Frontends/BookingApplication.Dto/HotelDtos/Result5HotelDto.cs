using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Dto.HotelDtos
{
    public class Result5HotelDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stars { get; set; }
        public int Rating { get; set; }
        public string Location { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public string HotemlAmentities { get; set; }
        public string Policy { get; set; }
        public string Cancellation { get; set; }
        public int AgeRequirement { get; set; }
        public int Price { get; set; }
        public int CurrencyID { get; set; }
        public string CurrencyName { get; set; }
        public string Image { get; set; }
    }
}
