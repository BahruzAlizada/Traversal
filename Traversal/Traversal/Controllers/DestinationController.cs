using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Traversal.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());
        #region Index
        public async Task<IActionResult> Index()
        {
            List<Destination> destinations = await destinationManager.GetListAsync();
            return View(destinations);
        }
        #endregion

        #region Detail
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();
            Destination destination = await destinationManager.GetByIdAsync(id);
            if (destination == null)
                return BadRequest();

            return View(destination);
        }
        #endregion
    }
}
