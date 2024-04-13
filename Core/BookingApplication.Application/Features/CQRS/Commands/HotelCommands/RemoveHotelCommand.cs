using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Commands.HotelCommands
{
    public class RemoveHotelCommand
    {
        public int Id { get; set; }

        public RemoveHotelCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
