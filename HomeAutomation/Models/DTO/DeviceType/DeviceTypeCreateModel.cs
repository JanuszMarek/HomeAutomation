using HomeAutomation.Models.DTO.Abstract;
using System.ComponentModel.DataAnnotations;

namespace HomeAutomation.Models.DTO.DeviceType
{
    public class DeviceTypeCreateModel : BaseCreateModel
    {
        [Required]
        public long CategoryId { get; set; }
    }
}
