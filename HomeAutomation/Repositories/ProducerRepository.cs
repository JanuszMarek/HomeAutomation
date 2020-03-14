using AutoMapper;
using HomeAutomation.Models.Context;
using HomeAutomation.Models.Entities;
using HomeAutomation.Repositories.Interfaces;

namespace HomeAutomation.Repositories
{
    public class ProducerRepository: BaseRepository<Producer>, IProducerRepository
    {
        public ProducerRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
