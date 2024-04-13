using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Domain.Entities
{
    public class HotelRoom
    {
        public int HotelRoomID { get; set; }
        public int RoomPrice { get; set; }
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public string RoomImage { get; set; }
        public int HotelID { get; set; }
        public Hotel Hotel { get; set; }
        public List<HotelReservation> HotelReservations { get; set; }
    }
}
