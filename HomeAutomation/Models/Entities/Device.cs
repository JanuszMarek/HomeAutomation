using HomeAutomation.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace HomeAutomation.Models.Entities
{
    public class Device : Concurrency
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public long ProducerId { get; set; }

        public Producer Producer { get; set; }
        
        public long DeviceTypeId { get; set; }

        public DeviceType DeviceType { get; set; }

    }
}
