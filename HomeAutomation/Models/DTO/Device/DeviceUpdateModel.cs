using HomeAutomation.Models.DTO.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace HomeAutomation.Models.DTO.Device
{
    public class DeviceUpdateModel : DeviceInputModel, IBaseUpdateModel
    {
        [Required]
        public long Id { get; set; }
    }
}
