using HomeAutomation.Models.Abstract.Interfaces;
using HomeAutomation.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Models.Abstract
{
    public class Entity : Concurrency, IEntity, ICreateDate, IUpdateDate
    {
        public long Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
