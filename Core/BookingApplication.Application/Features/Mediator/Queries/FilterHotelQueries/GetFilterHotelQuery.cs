using BookingApplication.Application.Features.Mediator.Results.FilterHotelResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Queries.FilterHotelQueries
{
    public class GetFilterHotelQuery:IRequest<List<GetFilterHotelQueryResult>>
    {
        public int LocationID { get; set; }
    }
}
