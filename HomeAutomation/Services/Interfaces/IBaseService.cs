using HomeAutomation.Models.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeAutomation.Services.Interfaces
{
    public interface IBaseService<T> where T: Entity
    {
        Task<T> GetByIdAsync(long id);
        Task<IEnumerable<T>> GetAsync();
        void Update(T entity);
        void Delete(T entity);
        Task CreateAsync(T entity);
    }
}
