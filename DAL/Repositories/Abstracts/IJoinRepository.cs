using MODEL.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Abstracts
{
    public interface IJoinRepository<T,TKey1,TKey2> where T : class,IJoinEntity<TKey1,TKey2>
    {
        IQueryable<T> GetAll();
        Task<T> GetByIdsAsync(TKey1 firstId, TKey2 secondId);
        Task AddAsync(T entity);
        Task RemoveAsync(T entity);
        Task UpdateAsync(T entity);
    }
}
