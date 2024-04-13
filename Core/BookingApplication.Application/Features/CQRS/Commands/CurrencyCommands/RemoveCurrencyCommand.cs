using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Commands.CurrencyCommands
{
    public class RemoveCurrencyCommand
    {
        public int Id { get; set; }

        public RemoveCurrencyCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
