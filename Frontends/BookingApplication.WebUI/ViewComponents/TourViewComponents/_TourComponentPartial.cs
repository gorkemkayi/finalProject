﻿using BookingApplication.Dto.TourDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookingApplication.WebUI.ViewComponents.TourViewComponents
{
    public class _TourComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _TourComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7012/api/Tours/TourList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTourDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
