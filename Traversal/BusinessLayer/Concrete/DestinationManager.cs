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
    public class DestinationManager : IDestinantionService
    {
        IDestinationDal _DestinationDal;
        public DestinationManager(IDestinationDal destinationDal)
        {
            _DestinationDal = destinationDal;
        }

        public async Task<Destination> GetByIdAsync(int? id)
        {
            using var c = new Context();
            return await c.Set<Destination>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Destination>> GetListAsync()
        {
            using var c = new Context();
            return await c.Set<Destination>().ToListAsync();
        }

        public async Task<Destination> IncludeAsync(int? id)
        {
            using var c = new Context();
            return await c.Set<Destination>().Include(x => x.DestinationDetail).FirstOrDefaultAsync(x=>x.Id==id);
        }

        public Task TAddasync(Destination t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Destination t)
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(Destination t)
        {
            throw new NotImplementedException();
        }
    }
}
