using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Queries.CurrencyQueries
{
    public class GetCurrencyByIdQuery
    {
        public int Id { get; set; }

        public GetCurrencyByIdQuery(int id)
        {
            Id = id;
        }
    }
}
