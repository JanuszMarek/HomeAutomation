using HomeAutomation.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace HomeAutomation.Models.Entities
{
    public class Producer : Concurrency
    {
        [Key]
        public long Id { get; set; } 

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
