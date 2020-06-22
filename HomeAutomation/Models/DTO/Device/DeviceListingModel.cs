using HomeAutomation.Models.DTO.DeviceType;
using HomeAutomation.Models.DTO.Producer;
using HomeAutomation.Models.Enums;

namespace HomeAutomation.Models.DTO.Device
{
    public class DeviceListingModel : DeviceBaseModel
    {
        public ConnectionEnum Connection { get; set; }
        public ProducerBaseModel Producer { get; set; }
        public DeviceTypeBaseModel DeviceType { get; set; }
    }
}
