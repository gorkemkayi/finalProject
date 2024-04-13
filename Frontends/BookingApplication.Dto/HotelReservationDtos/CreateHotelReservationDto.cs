using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Dto.HotelReservationDtos
{
    public class CreateHotelReservationDto
    {
        //public string RoomNumber { get; set; }
        public int HotelRoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
