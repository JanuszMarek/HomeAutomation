using HomeAutomation.Models.DTO.Interfaces;

namespace HomeAutomation.Models.DTO.DeviceType
{
    public class DeviceTypeModel : IBaseModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public long CategoryId { get; set; }
    }
}
