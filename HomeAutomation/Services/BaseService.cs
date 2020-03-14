using AutoMapper;
using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.DTO.Interfaces;
using HomeAutomation.Repositories.Interfaces;
using HomeAutomation.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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

        public async Task<long> CreateAsync(IBaseInputModel inputModel)
        {
            var entity = mapper.Map<T>(inputModel);

            repository.Create(entity);
            await SaveChangesAsync();
            return entity.Id;
        }

        public async Task DeleteAsync(long id)
        {
            var entity = await repository.GetEntityById(id);

            repository.Delete(entity);
            await SaveChangesAsync();
        }

        public async Task<DTO> GetByIdAsync<DTO>(long id) where DTO : IBaseModel
        {
            return await repository.GetById<DTO>(id);
        }

        public async Task<List<DTO>> Get<DTO>(Expression<Func<DTO, bool>> filter = null, Func<DTO, object> orderBy = null) where DTO : IBaseModel
        {
            return await repository.Get(filter, orderBy);
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
            var entity = await repository.GetEntityById(updateModel.Id);
            mapper.Map(updateModel, entity);
            repository.Update(entity);
            await SaveChangesAsync();
        }
    }
}
