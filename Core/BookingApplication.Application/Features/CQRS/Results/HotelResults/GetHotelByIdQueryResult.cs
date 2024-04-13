﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Results.HotelResults
{
    public class GetHotelByIdQueryResult
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stars { get; set; }
        public int Rating { get; set; }
        //public string Location { get; set; }
        public int LocationID { get; set; }
        public string LocationName { get; set; }
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
