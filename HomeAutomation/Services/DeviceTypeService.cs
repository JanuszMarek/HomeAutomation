using HomeAutomation.Models.Entities;
using HomeAutomation.Repositories.Interfaces;
using HomeAutomation.Services.Interfaces;

namespace HomeAutomation.Services
{
    public class DeviceTypeService : BaseService<DeviceType>, IDeviceTypeService
    {
        public DeviceTypeService(IBaseRepository<DeviceType> repository) : base(repository)
        { }
    }
}
