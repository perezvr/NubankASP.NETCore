using NubankCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NubankCore.Repositories.Interfaces
{
    public interface IRespositoryBase<T> where T : ModelBase
    {
        Task AddAsync(T t);
        void UpdateAsync(T t);
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        Task DeleteAsync(int id);
    }
}
