using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Commands.LocationCommands
{
    public class UpdateLocationCommand:IRequest
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
