using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUsController : Controller
    {
        private readonly IContactFormService _contactForm;
        public ContactUsController(IContactFormService contactForm)
        {
            _contactForm = contactForm;
        }
        public async Task<IActionResult> Index()
        {
            List<ContactForm> contact = await _contactForm.GetListAsync();
            return View(contact);
        }
    }
}
