using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.ViewComponents
{
    public class TestimonialViewComponent : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EFTestimonailDal()); 
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Testimonial> testimonials = await testimonialManager.GetListAsync();
            List<Testimonial> testimonialLimit =  testimonials.OrderByDescending(x=>x.Id).Take(4).ToList();
            return View(testimonialLimit);
        }
    }
}
