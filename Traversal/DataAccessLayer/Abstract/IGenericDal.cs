using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        Task InsertAsync(T t);
        Task UpdateAsync(T t);
        void Delete(T t);
        Task<List<T>> GetListAsync();
    }
}
