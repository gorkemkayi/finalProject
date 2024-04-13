using BookingApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Results.FilterHotelRoomResults
{
    public class GetFilterHotelRoomQueryResults
    {
        public int HotelRoomID { get; set; }
        public int RoomPrice { get; set; }
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public string RoomImage { get; set; }
        public int HotelID { get; set; }
        public string HotelName { get; set; }
    }
}
