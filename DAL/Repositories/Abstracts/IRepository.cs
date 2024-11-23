using MODEL.Abstract.BaseEntities;
using MODEL.Abstract.Enums;
using MODEL.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Abstracts
{
    public interface IRepository<T> where T: BaseEntity
    {
        IQueryable<T> GetAll();

        IQueryable<T> GetActives();

        IQueryable<T> GetPassives();

        T  GetById(int id);

        Task CreateAsync(T item);

        Task CreateRangeAsync(List<T> item);

        Task DeleteAsync(T item);

        Task DeleteRangeAsync(List<T> item);

        Task UpdateAsync(T item);

        Task UpdateRangeAsync(List<T> item);

        void Destroy(T item);

        void DestroyRange(List<T> items);
    }

    

}
