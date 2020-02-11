using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.DTO.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeAutomation.Services.Interfaces
{
    public interface IBaseService<T> where T: Entity
    {
        Task<T> GetByIdAsync(long id);
        Task UpdateAsync(IBaseUpdateModel updateModel);
        Task DeleteAsync(long id);
        Task CreateAsync(IBaseInputModel entity);
        Task SaveChangesAsync();

    }
}
