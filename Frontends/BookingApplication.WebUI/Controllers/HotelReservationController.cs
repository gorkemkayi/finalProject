using BookingApplication.Dto.FlightReservationDtos;
using BookingApplication.Dto.HotelReservationDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Common;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace BookingApplication.WebUI.Controllers
{
    [Authorize(Roles ="Admin,Member")]
    public class HotelReservationController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HotelReservationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index(int id)
        {
			ViewBag.v1 = "Flight Reservation";
			ViewBag.v2 = "Flight Reservation Form";
			ViewBag.RoomId = id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateHotelReservationDto createHotelReservationDto)
        {
            var token = User.Claims.FirstOrDefault(x => x.Type == "accesstoken")?.Value;
            if (token!=null)
            {
				var client = _httpClientFactory.CreateClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
				var jsonData = JsonConvert.SerializeObject(createHotelReservationDto);
				StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
				var responseMessage = await client.PostAsync("https://localhost:7012/api/HotelReservation/CreateHotelReservation", stringContent);
				if (responseMessage.IsSuccessStatusCode)
				{
					return RedirectToAction("Index", "Default");
				}                
			}            
            return View();
        }
    }
}

