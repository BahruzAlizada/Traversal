using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Traversal.ViewComponents
{
    public class SubAboutViewComponent : ViewComponent
    {
        SubAboutManager SubAboutManager = new SubAboutManager(new EFSubAboutDal());
        public async Task<IViewComponentResult> InvokeAsync()
        {
            SubAbout subAbout = await SubAboutManager.GetBySubAboutOneAsync();
            return View(subAbout);
        }
    }
}
