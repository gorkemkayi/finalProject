using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Dto.HotelDtos
{
    public class ResultHotelDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int stars { get; set; }
        public int rating { get; set; }
        public string location { get; set; }
        public DateTime checkin { get; set; }
        public DateTime checkout { get; set; }
        public string hotemlAmentities { get; set; }
        public string policy { get; set; }
        public string cancellation { get; set; }
        public int ageRequirement { get; set; }
        public int price { get; set; }
        public int currencyID { get; set; }
        public string currencyName { get; set; }
        public string image { get; set; }
    }

}

