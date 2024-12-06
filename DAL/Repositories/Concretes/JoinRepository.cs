using DAL.Context;
using DAL.Repositories.Abstracts;
using MODEL.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concretes
{
    public class JoinRepository<T, TKey1, TKey2> : IJoinRepository<T, TKey1, TKey2> where T : class, IJoinEntity<TKey1, TKey2>
    {
        private readonly ProjectContext context;

        public JoinRepository(ProjectContext _context)
        {
            context = _context;
        }
        public IQueryable<T> GetAll()
        {
            return context.Set<T>();
        }
        public async Task<T> GetByIdsAsync(TKey1 firstId, TKey2 secondId)
        {
            return await context.Set<T>().FindAsync(firstId,secondId);
        }

        public async Task AddAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
        }

        

        

        public async Task RemoveAsync(T entity)
        {
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
           var existingEntity = await GetByIdsAsync(entity.FirstID, entity.SecondID);
            if (existingEntity != null) 
            {
                context.Entry(existingEntity).CurrentValues.SetValues(entity);
                await context.SaveChangesAsync();
            }
        }
    }
}
