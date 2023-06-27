using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SliderManager : ISliderService
    {
        ISliderDal _sliderDal;
        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;     
        }
        public Task<Slider> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Slider>> GetListAsync()
        {
            using var c = new Context();
            return await c.Set<Slider>().ToListAsync();
        }

        public Task TAddasync(Slider t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Slider t)
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(Slider t)
        {
            throw new NotImplementedException();
        }
    }
}
