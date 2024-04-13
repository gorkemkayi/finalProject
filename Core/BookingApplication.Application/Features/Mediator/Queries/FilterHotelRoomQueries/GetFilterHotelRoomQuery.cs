using BookingApplication.Application.Features.Mediator.Results.FilterHotelRoomResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Queries.FilterHotelRoomQueries
{
    public class GetFilterHotelRoomQuery:IRequest<List<GetFilterHotelRoomQueryResults>>
    {
        public int HotelID { get; set; }
    }
}
