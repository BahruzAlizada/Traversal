using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Traversal.ViewComponents
{
    public class ContactInfoViewComponent : ViewComponent
    {
        ContactInfoManager contactInfoManager = new ContactInfoManager(new EFContactInfoDal());

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ContactInfo contactInfo = await contactInfoManager.GetByIdAsync(1);
            return View(contactInfo);
        }
    }
}
