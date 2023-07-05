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
    public class ApiMovieController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<ApiMovieVM> apimovie = new List<ApiMovieVM>();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies1.p.rapidapi.com/"),
                Headers =
    {
        { "X-RapidAPI-Key", "04bf23588dmsh31ff6fa6ff21f9cp164c1fjsn2103d15b2efd" },
        { "X-RapidAPI-Host", "imdb-top-100-movies1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                apimovie = JsonConvert.DeserializeObject<List<ApiMovieVM>>(body);
                return View(apimovie);
            }
           
        }
    }
}
