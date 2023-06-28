using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Traversal.Controllers
{
    [AllowAnonymous]
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
            Destination destination = await destinationManager.IncludeAsync(id);
            if (destination == null)
                return BadRequest();
            return View(destination);
        }
        #endregion
    }
}
