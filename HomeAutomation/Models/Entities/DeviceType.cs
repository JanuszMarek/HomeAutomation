using HomeAutomation.Models.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeAutomation.Models.Entities
{
    public class DeviceType : Concurrency
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [ForeignKey("Category")]
        public long CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
