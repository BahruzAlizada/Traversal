using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class //Just class
    {
        public void Delete(T t)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetListAsync()
        {
            using var c = new Context();
            return await c.Set<T>().ToListAsync();
        }

        public Task InsertAsync(T t)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T t)
        {
            throw new NotImplementedException();
        }
    }
}
