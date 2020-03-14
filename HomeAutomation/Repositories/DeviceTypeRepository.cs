using AutoMapper;
using HomeAutomation.Models.Context;
using HomeAutomation.Models.Entities;
using HomeAutomation.Repositories.Interfaces;

namespace HomeAutomation.Repositories
{
    public class DeviceTypeRepository: BaseRepository<DeviceType>, IDeviceTypeRepository
    {
        public DeviceTypeRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
