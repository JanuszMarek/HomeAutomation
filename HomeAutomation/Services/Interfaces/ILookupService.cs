using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeAutomation.Services.Interfaces
{
    public interface ILookupService
    {
        Task<IEnumerable<LookupModel>> GetEntityToLookupAsync<T>() where T : Entity;
    }
}
