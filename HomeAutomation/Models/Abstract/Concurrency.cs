using System;

namespace HomeAutomation.Models.Abstract
{
    public class Concurrency
    {
        public byte[] RowVersion { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ModifyDate { get; set; }
    }
}
