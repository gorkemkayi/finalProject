using BookingApplication.Dto.FlightDtos;
using BookingApplication.Dto.FlightReservationDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookingApplication.WebUI.Controllers
{
    public class FlightsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FlightsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7012/api/Flights/FlightList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<ResultFeaturedFlightsDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
