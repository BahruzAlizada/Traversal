using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Traversal.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        SliderManager sliderManager = new SliderManager(new EFSliderDal());
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Slider> sliders = await sliderManager.GetListAsync();
            return View(sliders);
        }
    }
}
