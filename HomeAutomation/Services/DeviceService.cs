using AutoMapper;
using HomeAutomation.Models.Entities;
using HomeAutomation.Repositories.Interfaces;
using HomeAutomation.Services.Interfaces;

namespace HomeAutomation.Services
{
    public class DeviceService : BaseService<Device>, IDeviceService
    {
        public DeviceService(IBaseRepository<Device> repository, IMapper mapper) : base(repository, mapper)
        { }
    }
}
