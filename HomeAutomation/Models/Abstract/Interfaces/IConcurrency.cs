﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Models.Abstract.Interfaces
{
    public interface IConcurrency
    {
        byte[] RowVersion { get; set; }
    }
}
