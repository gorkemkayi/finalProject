using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Commands.AirlineCommands
{
    public class CreateAirlineCommand
    {
        public string Name { get; set; }
        public string Image { get; set; }

    }
}
