using BookingApplication.Application.Features.Mediator.Queries.FilterHotelRoomQueries;
using BookingApplication.Application.Features.Mediator.Results.FilterHotelRoomResults;
using BookingApplication.Application.Interfaces.HotelRoomInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Handlers.FilterHotelRoomHandlers
{
    public class GetFilterHotelRoomQueryHandler : IRequestHandler<GetFilterHotelRoomQuery, List<GetFilterHotelRoomQueryResults>>
    {
        private readonly IHotelRoomRepository _hotelRoomRepository;

        public GetFilterHotelRoomQueryHandler(IHotelRoomRepository hotelRoomRepository)
        {
            _hotelRoomRepository = hotelRoomRepository;
        }

        public async Task<List<GetFilterHotelRoomQueryResults>> Handle(GetFilterHotelRoomQuery request, CancellationToken cancellationToken)
        {
            var values=await _hotelRoomRepository.GetByFilterAsync(x=>x.HotelID==request.HotelID);
            var results=values.Select(x=>new GetFilterHotelRoomQueryResults
            {
                HotelRoomID = x.HotelRoomID,
                RoomPrice = x.RoomPrice,
                RoomNumber = x.RoomNumber,
                RoomType= x.RoomType,
                HotelID =x.HotelID,  
                HotelName=x.Hotel.Name,
                RoomImage=x.RoomImage,
                
            }).ToList();
            return results;
        }
    }
}

