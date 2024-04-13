using BookingApplication.Dto.FlightDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookingApplication.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultFeaturedFlightsComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultFeaturedFlightsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7012/api/Flights/GetFeaturedFlights");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<ResultFeaturedFlightsDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
