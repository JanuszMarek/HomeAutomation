using HomeAutomation.Models.DTO.Interfaces;

namespace HomeAutomation.Models.DTO.Device
{
    public class DeviceModel : IBaseModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public long ProducerId { get; set; }

        public long DeviceTypeId { get; set; }
    }
}
