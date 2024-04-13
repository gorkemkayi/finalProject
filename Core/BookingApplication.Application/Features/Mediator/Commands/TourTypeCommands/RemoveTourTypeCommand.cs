using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Commands.TourTypeCommands
{
    public class RemoveTourTypeCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveTourTypeCommand(int id)
        {
            Id = id;
        }
    }
}
