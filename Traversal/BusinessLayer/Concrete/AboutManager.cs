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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal; 
        public AboutManager(IAboutDal aboutDal) //Dependcy Injection
        {
            _aboutDal = aboutDal;
        }

        public async Task<About> GetByAboutOne()
        {
            using var c = new Context();
            return await c.Set<About>().FirstOrDefaultAsync();
        }

        public Task<About> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<About>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task TAddasync(About t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(About t)
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(About t)
        {
            throw new NotImplementedException();
        }
    }
}
