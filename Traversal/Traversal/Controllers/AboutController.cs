using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Traversal.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EFAboutDal());
        public async Task<IActionResult> Index()
        {
            About about = await aboutManager.GetByAboutOne();
            return View(about);
        }
    }
}
