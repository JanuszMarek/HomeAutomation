using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HomeAutomation.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : Entity
    {
        Task<T> GetEntityById(long id);
        Task<DTO> GetById<DTO>(long id) where DTO : IBaseModel;
        Task<List<DTO>> Get<DTO>(Expression<Func<DTO, bool>> filter = null, Func<DTO, object> orderBy = null) where DTO : IBaseModel;
        void Update(T entity);
        void Delete(T entity);
        void Create(T entity);
        Task<bool> SaveChanges();
        Task<bool> Exists(long id);
    }
}
