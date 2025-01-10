using DAL.Context;
using DAL.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MODEL.Abstract.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concretes
{
    public class Repository<T> : IRepository<T> where T : BaseEntity 
    {
        private readonly ProjectContext _context;

        public Repository(ProjectContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(T item)
        {

            await _context.Set<T>().AddAsync(item);
            await _context.SaveChangesAsync();
            
        }

        public async Task CreateRangeAsync(List<T> item)
        {
            await _context.Set<T>().AddRangeAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T item)
        {
            item.Status = MODEL.Abstract.Enums.DataStatus.Inactive;
            await UpdateAsync(item);
        }

        public async Task DeleteRangeAsync(List<T> item)
        {
            foreach (T deleteitem in item)
            {
                await DeleteAsync(deleteitem);
            }
        }

        public void Destroy(T item)
        {
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
        }

        public async void DestroyRange(List<T> items)
        {
            foreach(T destroyitem in items)
            {
                 Destroy(destroyitem);
            }
        }

        public IQueryable<T> GetActives()
        {
            return _context.Set<T>().Where(x=>x.Status == MODEL.Abstract.Enums.DataStatus.Active);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IQueryable<T> GetPassives()
        {
            return _context.Set<T>().Where(x => x.Status == MODEL.Abstract.Enums.DataStatus.Inactive);
        }

        public async Task UpdateAsync(T item)
        {
            var data = await _context.Set<T>().FindAsync(item.ID);
            _context.Entry(data).CurrentValues.SetValues(item);
            _context.SaveChanges();
        }

        public async Task UpdateRangeAsync(List<T> item)
        {
            foreach (var model in item)
            {
                await UpdateAsync(model);
            }
        }
    }
}
