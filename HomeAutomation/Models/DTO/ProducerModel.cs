using HomeAutomation.Models.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Models.DTO
{
    public class ProducerModel : IProducerModel
    {
        public long Id { get; set; }

        public string Name { get; set; }
    }
}
