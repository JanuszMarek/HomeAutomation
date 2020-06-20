using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.DTO.Interfaces;

namespace HomeAutomation.Models.DTO.DeviceType
{
    public class DeviceTypeEditModel : Concurrency, IBaseModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public long CategoryId { get; set; }
        public long ImageId { get; set; }
    }
}
