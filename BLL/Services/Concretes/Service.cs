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
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public async Task CreateAsync(T item)
        {
            if(item == null) throw new ArgumentNullException(nameof(item));
            await _repository.CreateAsync(item);
            
        }

        public async Task CreateRangeAsync(List<T> item)
        {
            if(item == null || !item.Any()) throw new ArgumentNullException(nameof(item));
            await _repository.CreateRangeAsync(item);
        }

        public async Task DeleteAsync(T item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            await _repository.DeleteAsync(item);
        }

        public async Task DeleteRangeAsync(List<T> item)
        {
            if (item == null || !item.Any()) throw new ArgumentNullException(nameof(item)); 
            await _repository.DeleteRangeAsync(item);
        }

        public void Destroy(T item)
        {
            if(item == null) throw new ArgumentNullException(nameof(item));
            _repository.Destroy(item);
        }

        public void DestroyRange(List<T> items)
        {
            if (items  == null || !items.Any()) throw new ArgumentNullException(nameof(items));
            _repository.DestroyRange(items);
        }

        public IEnumerable<T> GetActives()
        {
            return _repository.GetActives().ToList();
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public T GetById(int id)
        {
            if(id <= 0 ) throw new ArgumentOutOfRangeException(nameof(id));
            var entity = _repository.GetById(id);
            if(entity == null) throw new KeyNotFoundException($"Entity with ID {id} not found");
            return _repository.GetById(id);
        }

        public IEnumerable<T> GetPassives()
        {
            return _repository.GetPassives().ToList();
        }

        public async Task UpdateAsync(T item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            await _repository.UpdateAsync(item);    
        }

        public async Task UpdateRangeAsync(List<T> item)
        {
            if (item == null || !item.Any()) throw new ArgumentNullException(nameof (item));            
            await _repository.UpdateRangeAsync(item);
        }
        //private void ValidateNotNull(object obj, string message)
        //{
        //    if (obj == null) throw new ArgumentNullException(message);
        //}
        //private void ValidateListNotNullOrEmpty(IEnumerable<T> lists,string paramName)
        //{
        //    if(lists == null || !lists.Any())) throw new ArgumentException("The list is either null or empty.",paramName);
        //}
    }
}
