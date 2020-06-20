﻿using HomeAutomation.Models.DTO.DeviceType;
using HomeAutomation.Models.DTO.Interfaces;
using HomeAutomation.Models.DTO.Producer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Models.DTO.Device
{
    public class DeviceListingModel : DeviceBaseModel
    {
        public string ImageUrl { get; set; }
        public ProducerBaseModel Producer { get; set; }
        public DeviceTypeBaseModel DeviceType { get; set; }
    }
}
