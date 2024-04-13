using BookingApplication.Dto.FlightReservationDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BookingApplication.WebUI.Controllers
{
    public class ReserveFlightController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ReserveFlightController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index(int id)
        {
            var airportid = TempData["airportId"];

            id = int.Parse(airportid.ToString());

            ViewBag.airportid = airportid;

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7012/api/FlightReserve/GetFlightsByAirport?airportid={id}&available=true");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<FilterReservationFlightDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
