using System;

namespace HomeAutomation.Models.Abstract
{
    public class ConcurrencyDates : Concurrency
    {
        public DateTime CreationDate { get; set; }

        public DateTime ModifyDate { get; set; }
    }
}
