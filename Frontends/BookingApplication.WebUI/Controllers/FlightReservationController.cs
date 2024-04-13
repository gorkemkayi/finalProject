using BookingApplication.Dto.FlightReservationDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http.Headers;

namespace BookingApplication.WebUI.Controllers
{
    [Authorize(Roles ="Admin,Member")]
    public class FlightReservationController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FlightReservationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index(int id)
        {
            ViewBag.v1 = "Flight Reservation";
            ViewBag.v2 = "Flight Reservation Form";
            ViewBag.v3 = id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateFlightReservationDto createFlightReservationDto)
        {
            var token=User.Claims.FirstOrDefault(x=>x.Type == "accessToken")?.Value;
            if (token!=null)
            {               
                var client = _httpClientFactory.CreateClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var jsonData = JsonConvert.SerializeObject(createFlightReservationDto);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PostAsync("https://localhost:7012/api/FlightReservations/CreateFlightReservation", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Default");
                }
            }

            return View();
        }
    }
}
