using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.DTO.Interfaces;

namespace HomeAutomation.Models.DTO.Device
{
    public class DeviceEditModel : Concurrency, IBaseModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public long ProducerId { get; set; }

        public long DeviceTypeId { get; set; }
    }
}
