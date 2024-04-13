using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Commands.CurrencyCommands
{
    public class UpdateCurrencyCommand
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
