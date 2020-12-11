using Microsoft.EntityFrameworkCore;
using NubankCore.Connection;
using NubankCore.Models;
using NubankCore.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NubankCore.Repositories
{
    public class RepositoryBase<T> : IRespositoryBase<T> where T : ModelBase
    {
        private readonly ApplicationContext _applicationContext;
        protected readonly DbSet<T> DBSet;

        public RepositoryBase(ApplicationContext applicationContext)
        {
            this._applicationContext = applicationContext;
            DBSet = _applicationContext.Set<T>();
        }

        public void AddAsyncold(T t)
        {
            DBSet.Add(t);
            _applicationContext.SaveChanges();
        }

        public async Task AddAsync(T t)
        {
            await DBSet.AddAsync(t);
            await _applicationContext.SaveChangesAsync();
        }

        public void UpdateAsync(T t)
        {
            _applicationContext.Entry(t).State = EntityState.Modified;
            _applicationContext.SaveChanges();
        }

        public async Task<List<T>> GetAllAsync() => await DBSet.ToListAsync();

        public async Task<T> GetAsync(int id) => await DBSet.FindAsync(id);

        public async Task DeleteAsync(int id) => DBSet.Remove(await GetAsync(id));
    }
}
