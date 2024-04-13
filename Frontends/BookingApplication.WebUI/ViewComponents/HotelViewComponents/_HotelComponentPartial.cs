using BookingApplication.Dto.HotelDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookingApplication.WebUI.ViewComponents.HotelViewComponents
{
    public class _HotelComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HotelComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responmeMessage = await client.GetAsync("https://localhost:7012/api/Hotels/HotelList");
            if (responmeMessage.IsSuccessStatusCode) 
            {
                    var jsonData=await responmeMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<ResultHotelDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }

}
