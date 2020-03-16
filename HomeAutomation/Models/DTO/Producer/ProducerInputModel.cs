using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.DTO.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace HomeAutomation.Models.DTO.Producer
{
    public class ProducerInputModel : Concurrency, IBaseInputModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }
    }
}
