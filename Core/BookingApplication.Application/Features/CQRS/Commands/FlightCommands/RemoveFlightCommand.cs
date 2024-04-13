using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Commands.FlightCommands
{
    public class RemoveFlightCommand
    {
        public int Id { get; set; }

        public RemoveFlightCommand(int id)
        {
            Id = id;
        }
    }
}
