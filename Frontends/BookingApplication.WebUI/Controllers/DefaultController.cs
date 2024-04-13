using BookingApplication.Dto.AirportDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace BookingApplication.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7012/api/Airport/AirportList");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultAirportDto>>(jsonData);
            List<SelectListItem> values2=(from x in values select new SelectListItem
            {
                Text=x.Name,
                Value=x.Id.ToString()
            }).ToList();
            ViewBag.v=values2;
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Id, string LandingCity)
        {
            TempData["airportId"] = Id;
            TempData["LandingCity"] = LandingCity;
            return RedirectToAction("Index","ReserveFlight");
        }
    }
}
