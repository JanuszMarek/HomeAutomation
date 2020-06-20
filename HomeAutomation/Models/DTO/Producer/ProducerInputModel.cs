using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.DTO.Interfaces;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace HomeAutomation.Models.DTO.Producer
{
    public class ProducerInputModel : Concurrency, IBusinessInputModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public long ImageId { get; set; }
    }
}
