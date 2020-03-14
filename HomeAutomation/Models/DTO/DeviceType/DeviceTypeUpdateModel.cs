using HomeAutomation.Models.DTO.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace HomeAutomation.Models.DTO.DeviceType
{
    public class DeviceTypeUpdateModel : DeviceTypeInputModel, IBaseUpdateModel
    {
        [Required]
        public long Id { get; set; }
    }
}
