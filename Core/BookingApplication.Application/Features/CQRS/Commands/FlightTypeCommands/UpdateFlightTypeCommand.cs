using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Commands.FlightTypeCommands
{
    public class UpdateFlightTypeCommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
