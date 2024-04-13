﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using BookingApplication.Dto.HotelDtos;
namespace BookingApplication.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultGet5HotelsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultGet5HotelsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7012/api/Hotels/Get5Hotel");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<Result5HotelDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
