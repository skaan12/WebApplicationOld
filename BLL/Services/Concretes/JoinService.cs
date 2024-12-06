using BLL.Services.Abstracts;
using MODEL.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Concretes
{
    public class JoinService<T, TKey1, TKey2> : IJoinService<T, TKey1, TKey2> where T : class, IJoinEntity<TKey1, TKey2>
    {
        private readonly IJoinService<T, TKey1, TKey2> _joinRepository;

        public JoinService(IJoinService<T,TKey1,TKey2> joinRepository)
        {
            _joinRepository = joinRepository;
        }
        public async Task AddAsync(T entity)
        {
            await _joinRepository.AddAsync(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _joinRepository.GetAll().ToList();
        }

        public async Task<T> GetByIdAsync(TKey1 firstId, TKey2 secondId)
        {
            return await _joinRepository.GetByIdAsync(firstId, secondId);
        }

        public async Task RemoveAsync(T entity)
        {
            await _joinRepository.RemoveAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            await _joinRepository.UpdateAsync(entity);
        }
    }
}
