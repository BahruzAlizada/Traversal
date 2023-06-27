using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Traversal.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        //private readonly ISliderDal _sliderDal;
        //public SliderViewComponent(ISliderDal sliderDal)
        //{
        //    sliderDal = _sliderDal;
        //}

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
