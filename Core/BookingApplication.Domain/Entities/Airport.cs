﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Domain.Entities
{
    public class Airport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Flight> Flights { get; set; }
    }
}
