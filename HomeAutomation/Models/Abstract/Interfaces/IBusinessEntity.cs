using HomeAutomation.Models.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Models.Abstract
{
    public interface IBusinessEntity : IEntity
    {
        string Name { get; set; }
        string Description { get; set; }
    }
}
