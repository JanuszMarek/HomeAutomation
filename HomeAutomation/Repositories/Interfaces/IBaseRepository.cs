using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.Abstract.Interfaces;
using HomeAutomation.Models.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : Entity
    {
        Task<T> GetById(long id);
        void Update(T entity);
        void Delete(T entity);
        void Create(T entity);
        Task<bool> SaveChanges();
        Task<bool> Exists(long id);
    }
}
