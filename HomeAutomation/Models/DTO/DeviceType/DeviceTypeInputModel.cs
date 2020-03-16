using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.DTO.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace HomeAutomation.Models.DTO.DeviceType
{
    public class DeviceTypeInputModel : Concurrency, IBaseInputModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public long CategoryId { get; set; }
    }
}
