using HomeAutomation.Models.DTO.Category;
using HomeAutomation.Models.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Models.DTO.DeviceType
{
    public class DeviceTypeListingModel : DeviceTypeBaseModel
    {
        public string ImageUrl { get; set; }
        public CategoryBaseModel Category { get; set; }
    }
}
