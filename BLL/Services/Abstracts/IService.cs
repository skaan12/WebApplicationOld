using DAL.Repositories.Abstracts;
using MODEL.Abstract.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Abstracts
{
    public interface IService<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();

        IEnumerable<T> GetActives();

        IEnumerable<T> GetPassives();

        T GetById(int id);

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
