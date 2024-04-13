using BookingApplication.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Commands.TourReservationCommands
{
    public class CreateTourReservationCommand:IRequest
    {
        public int TourID { get; set; }
        public int Person { get; set; }
    }
}
