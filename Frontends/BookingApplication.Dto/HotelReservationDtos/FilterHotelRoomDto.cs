using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Dto.HotelReservationDtos
{
    public class FilterHotelRoomDto
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
