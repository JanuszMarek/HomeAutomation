using HomeAutomation.Models.Abstract;
using HomeAutomation.Repositories.Interfaces;
using HomeAutomation.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeAutomation.Services
{
    public class BaseService<T> : IBaseService<T> where T : Entity
    {
        protected IBaseRepository<T> repository;

        public BaseService(IBaseRepository<T> repository)
        {
            this.repository = repository;
        }

        public async Task CreateAsync(T entity)
        {
            await repository.Create(entity);
        }

        public void Delete(T entity)
        {
            repository.Delete(entity);
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            return await repository.Get();
        }

        public async Task<T> GetByIdAsync(long id)
        {
            return await repository.GetById(id);
        }

        public void Update(T entity)
        {
            repository.Update(entity);
        }
    }
}
