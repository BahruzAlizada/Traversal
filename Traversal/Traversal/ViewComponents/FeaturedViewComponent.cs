using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.ViewComponents
{
    public class FeaturedViewComponent : ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Destination> destinations = await destinationManager.GetListAsync();
            List<Destination> destinationlimit = destinations.Where(x=>x.Featured).Take(5).ToList();
            return View(destinationlimit);
        }
    }
}
