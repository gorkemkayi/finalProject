using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Results.CurrencyResults
{
    public class GetCurrencyByIdQueryResult
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
