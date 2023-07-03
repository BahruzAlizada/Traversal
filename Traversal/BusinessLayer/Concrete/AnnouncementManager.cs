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
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;
        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal=announcementDal;
        }
        public async Task<Announcement> GetByIdAsync(int? id)
        {
            using var C = new Context();
            return await C.Set<Announcement>().FirstOrDefaultAsync(x=>x.Id==id);
        }

        public async Task<List<Announcement>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task TAddasync(Announcement t)
        {
            throw new NotImplementedException();
        
        }

        public void TDelete(Announcement t)
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(Announcement t)
        {
            throw new NotImplementedException();
        }
    }
}
