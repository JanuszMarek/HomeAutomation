using HomeAutomation.Models.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeAutomation.Models.Entities
{
    public class DeviceType : Entity
    {
        [ForeignKey("Category")]
        public long CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
