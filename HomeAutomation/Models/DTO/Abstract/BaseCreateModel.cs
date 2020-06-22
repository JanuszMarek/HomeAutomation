using HomeAutomation.Models.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Models.DTO.Abstract
{
    public class BaseCreateModel : IBaseCreateModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public long? ImageId { get; set; }
    }
}
