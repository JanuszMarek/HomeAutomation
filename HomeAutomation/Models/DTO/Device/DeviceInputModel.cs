using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.DTO.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace HomeAutomation.Models.DTO.Device
{
    public class DeviceInputModel : Concurrency, IBaseInputModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        [Required]
        public long ProducerId { get; set; }

        [Required]
        public long DeviceTypeId { get; set; }
    }
}
