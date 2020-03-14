using HomeAutomation.Models.DTO.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace HomeAutomation.Models.DTO.Producer
{
    public class ProducerUpdateModel : ProducerInputModel, IBaseUpdateModel
    {
        [Required]
        public long Id { get; set; }
    }
}
