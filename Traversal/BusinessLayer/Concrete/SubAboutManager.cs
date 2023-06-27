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
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAboutDal;
        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            subAboutDal = _subAboutDal;
        }
        public async Task<SubAbout> GetByIdAsync(int id)
        {
            using var c = new Context();
            return await c.Set<SubAbout>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<SubAbout> GetBySubAboutOneAsync()
        {
            using var c = new Context();
            return await c.Set<SubAbout>().FirstOrDefaultAsync();
        }

        public Task<List<SubAbout>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task TAddasync(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(SubAbout t)
        {
            throw new NotImplementedException();
        }
    }
}
