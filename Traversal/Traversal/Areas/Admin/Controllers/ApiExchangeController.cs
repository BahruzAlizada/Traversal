using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Traversal.ViewsModel;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ApiExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<BookingExchange2VM> bookingExchange = new List<BookingExchange2VM>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?currency=AZN&locale=en-gb"),
                Headers =
    {
        { "X-RapidAPI-Key", "04bf23588dmsh31ff6fa6ff21f9cp164c1fjsn2103d15b2efd" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
              var  values = JsonConvert.DeserializeObject<BookingExchange2VM>(body);
                return View(values.exchange_rates);
            }
           
        }
    }
}
