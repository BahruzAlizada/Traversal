using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Traversal.Models;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VisitorApiController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public VisitorApiController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        #region Index
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responeMessage = await client.GetAsync("http://localhost:41463/api/Visitor/VisitorList");
            if (responeMessage.IsSuccessStatusCode)
            {
                var jstonData = await responeMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<Visitor>>(jstonData);
                return View(values);
            }
            return View();
        }
        #endregion



        #region Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Visitor visitor)
        {
            var client = _httpClientFactory.CreateClient();

            var jsondata = JsonConvert.SerializeObject(visitor);
            StringContent content = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var responemessage = await client.PostAsync("http://localhost:41463/api/Visitor/VisitorAdd", content);
            if (responemessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion



        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            var client = _httpClientFactory.CreateClient();
            var responeMessage = await client.GetAsync($"http://localhost:41463/api/Visitor/{id}");
            if (responeMessage.IsSuccessStatusCode)
            {
                var jsondata=await responeMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<Visitor>(jsondata);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(Visitor visitor)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(visitor);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responeMessage = await client.PutAsync("http://localhost:41463/api/Visitor", content);
            if (responeMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion



        #region Delete
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responeMessage = await client.DeleteAsync($"http://localhost:41463/api/Visitor/{id}");
            if (responeMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion
    }
}
