using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Traversal.Helpers;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
		private readonly IWebHostEnvironment _env;
		private readonly IDestinantionService _destinantionService;
        public DestinationController(IDestinantionService destinantionService,IWebHostEnvironment env)
        {
            _env = env;
            _destinantionService = destinantionService;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            List<Destination> destinations = await _destinantionService.GetListAsync();
            return View(destinations);
        }
        #endregion

        #region Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Destination destination)
        {
            #region Image
            if (destination.Photo == null)
            {
                ModelState.AddModelError("Photo","Photo can not  be null");
                return View();
            }
            if (!destination.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Select Image type");
                return View();
            }
            if (destination.Photo.IsOlder512kb())
            {
                ModelState.AddModelError("Photo", "Max 512Kb");
                return View();
            }
            string folder = Path.Combine(_env.WebRootPath, "assets", "images");
            destination.Image = await destination.Photo.SaveFileAsync(folder);
            #endregion

            await _destinantionService.TAddasync(destination);          
            return RedirectToAction("Index");
        }
        #endregion
    }
}
