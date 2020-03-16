using HomeAutomation.Models.Abstract;

namespace HomeAutomation.Models.Entities
{
    public class Device : Entity
    {
        public decimal Price { get; set; }

        public long ProducerId { get; set; }

        public Producer Producer { get; set; }
        
        public long DeviceTypeId { get; set; }

        public DeviceType DeviceType { get; set; }
    }
}
