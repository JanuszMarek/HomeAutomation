using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.DTO.Interfaces;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace HomeAutomation.Models.DTO.DeviceType
{
    public class DeviceTypeInputModel : Concurrency, IBusinessInputModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public long CategoryId { get; set; }
        public IFormFile LogoFile { get; set; }
    }
}
