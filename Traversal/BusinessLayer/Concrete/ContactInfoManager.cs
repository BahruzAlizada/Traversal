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
    public class ContactInfoManager : IContactInfoService
    {
        IContactInfoDal _contactInfoDal;
        public ContactInfoManager(IContactInfoDal contactInfoDal)
        {
            _contactInfoDal = contactInfoDal;
        }
        public async Task<ContactInfo> GetByIdAsync(int? id)
        {
            using var c = new Context();
            return await c.Set<ContactInfo>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<List<ContactInfo>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task TAddasync(ContactInfo t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ContactInfo t)
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(ContactInfo t)
        {
            throw new NotImplementedException();
        }
    }
}
