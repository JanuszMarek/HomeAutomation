﻿using HomeAutomation.Models.DTO.Abstract;
using HomeAutomation.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace HomeAutomation.Models.DTO.Device
{
    public class DeviceEditModel : BaseEditModel
    {
        public decimal Price { get; set; }
        [Required]
        public long ProducerId { get; set; }
        [Required]
        public long DeviceTypeId { get; set; }
        public ConnectionEnum Connection { get; set; }
    }
}
