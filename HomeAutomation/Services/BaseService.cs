using AutoMapper;
using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.DTO.Interfaces;
using HomeAutomation.Repositories.Interfaces;
using HomeAutomation.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeAutomation.Services
{
    public class BaseService<T> : IBaseService<T> where T : Entity
    {
        protected IBaseRepository<T> repository;
        protected IMapper mapper;

        public BaseService(IBaseRepository<T> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task CreateAsync(IBaseInputModel inputModel)
        {
            var entity = mapper.Map<T>(inputModel);

            repository.Create(entity);
            await SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var entity = await GetByIdAsync(id);

            repository.Delete(entity);
            await SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(long id)
        {
            return await repository.GetById(id);
        }

        public async Task SaveChangesAsync()
        {
            if (!await repository.SaveChanges())
            {
                throw new Exception($"Saving {nameof(T)} failed on server");
            }
        }

        public async Task UpdateAsync(IBaseUpdateModel updateModel)
        {
            T entity = await GetByIdAsync(updateModel.Id);
            mapper.Map(updateModel, entity);
            repository.Update(entity);

            await SaveChangesAsync();
        }
    }
}
