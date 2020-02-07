using HomeAutomation.Models.Abstract.Interfaces;
using HomeAutomation.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeAutomation.Services
{
    public abstract class BaseService<T> : IBaseService<T> where T : IEntity
    {
        public BaseService()
        { }

        public Task CreateAsync(T entity)
        {

        }

        public void Delete(T entity)
        {

        }

        public Task<IEnumerable<T>> GetAsync()
        {

        }

        public Task<T> GetByIdAsync(long id)
        {

        }

        public void Update(T entity)
        {

        }
    }
}
