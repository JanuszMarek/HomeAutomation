using AutoMapper;
using HomeAutomation.Models.Entities;
using HomeAutomation.Repositories.Interfaces;
using HomeAutomation.Services.Interfaces;

namespace HomeAutomation.Services
{
    public class ProducerService : BaseService<Producer>, IProducerService
    {
        public ProducerService(IBaseRepository<Producer> repository, IMapper mapper) : base(repository, mapper)
        { }
    }
}
