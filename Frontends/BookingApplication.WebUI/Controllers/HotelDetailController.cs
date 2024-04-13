using BookingApplication.Dto.FlightReservationDtos;
using BookingApplication.Dto.HotelReservationDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BookingApplication.WebUI.Controllers
{
    public class HotelDetailController : Controller
    {
        private IHttpClientFactory _httpClientFactory;

        public HotelDetailController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            //var hotelid= id;
            //ViewBag.hotelid = hotelid;
            

            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7012/api/FilterHotelRooms/GetHotelRoomsByHotelID?hotelid={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FilterHotelRoomDto>>(jsonData);
                return View(values);
            }

            return View();
        }       


    }
}
