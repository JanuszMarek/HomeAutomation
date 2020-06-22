using HomeAutomation.Models.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Models.Abstract
{
    public class Concurrency : IConcurrency
    {
        public byte[] RowVersion { get; set; }
    }
}
