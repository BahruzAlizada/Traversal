using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        Task TAddasync(T t);
        void TDelete(T t);
        Task TUpdateAsync(T t);
        Task<T> GetByIdAsync(int? id);
        Task<List<T>> GetListAsync();
    }
}
