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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonailDal _testimonailDal;
        public TestimonialManager(ITestimonailDal testimonailDal)
        {
            _testimonailDal = testimonailDal;
        }
        public Task<Testimonial> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Testimonial>> GetListAsync()
        {
            using var c = new Context();
            return await c.Set<Testimonial>().ToListAsync();
        }

        public Task TAddasync(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(Testimonial t)
        {
            throw new NotImplementedException();
        }
    }
}
