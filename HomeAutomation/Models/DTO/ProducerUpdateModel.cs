using HomeAutomation.Models.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Models.DTO
{
    public class ProducerUpdateModel : ProducerInputModel, IBaseUpdateModel
    {
        [Required]
        public long Id { get; set; }
    }
}
