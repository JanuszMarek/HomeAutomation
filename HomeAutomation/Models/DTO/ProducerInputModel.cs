using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Models.DTO
{
    public abstract class ProducerInputModel : Concurrency, IBaseInputModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }
    }
}
