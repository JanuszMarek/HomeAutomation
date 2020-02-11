﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Models.DTO.Interfaces
{
    public interface IBaseModel
    {
        long Id { get; set; }

        string Name { get; set; }
    }
}
