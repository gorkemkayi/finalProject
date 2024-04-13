using BookingApplication.Dto.HotelReservationDtos;
using BookingApplication.Dto.TourReservationDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Common;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;

namespace BookingApplication.WebUI.Controllers
{
    public class TourReservationController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TourReservationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public  IActionResult Index(int id)
        {
            ViewBag.v1 = "Tour Reservation";
            ViewBag.v2 = "Tour Reservation Form";
            ViewBag.tourID = id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreatetourReservationDto createtourReservationDto)
        {
            var client= _httpClientFactory.CreateClient();
            var jsonData=JsonConvert.SerializeObject(createtourReservationDto);
            StringContent stringContent=new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("https://localhost:7012/api/TourReservation/CreateTourReservation", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}