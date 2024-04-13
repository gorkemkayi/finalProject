using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Commands.TourTypeCommands
{
    public class UpdateTourTypeCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
