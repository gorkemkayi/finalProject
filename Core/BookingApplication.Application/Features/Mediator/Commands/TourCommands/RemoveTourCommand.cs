using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Commands.TourCommands
{
    public class RemoveTourCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveTourCommand(int id)
        {
            Id = id;
        }
    }
}
