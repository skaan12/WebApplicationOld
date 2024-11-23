using BLL.Services.Abstracts;
using DAL.Repositories.Abstracts;
using MODEL.Abstract.BaseEntities;
using MODEL.Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Concretes
{
    public class Service<T> : IService<T> where T :  BaseEntity
    {
        private readonly IRepository<T> _repository;

        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }
        public Task CreateAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task CreateRangeAsync(List<T> item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeAsync(List<T> item)
        {
            throw new NotImplementedException();
        }

        public void Destroy(T item)
        {
            throw new NotImplementedException();
        }

        public void DestroyRange(List<T> items)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetActives()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetPassives()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(List<T> item)
        {
            throw new NotImplementedException();
        }
        
    }
}
