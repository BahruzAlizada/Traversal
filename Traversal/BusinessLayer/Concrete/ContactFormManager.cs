using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactFormManager : IContactFormService
    {
        IContactFormDal _contactFormDal;
        public ContactFormManager(IContactFormDal contactFormDal)
        {
            _contactFormDal=contactFormDal;
        }
        public Task<ContactForm> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ContactForm>> GetListAsync()
        {
           return await _contactFormDal.GetListAsync();
        }

        public Task TAddasync(ContactForm t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ContactForm t)
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(ContactForm t)
        {
            throw new NotImplementedException();
        }
    }
}
