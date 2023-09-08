using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormulaCar.Domain.IRepository
{
    public interface IGenericRepository <T> where T : class
    {
        Task<IEnumerable<T>> All();
        Task<T> GetbyId(Guid id);
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(Guid id);    
    }
}