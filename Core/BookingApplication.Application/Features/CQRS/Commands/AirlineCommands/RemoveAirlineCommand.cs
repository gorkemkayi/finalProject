using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Commands.AirlineCommands
{
    public class RemoveAirlineCommand
    {
        public int Id { get; set; }

        public RemoveAirlineCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
