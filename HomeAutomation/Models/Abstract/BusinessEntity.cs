using HomeAutomation.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeAutomation.Models.Abstract
{
    public class BusinessEntity : Entity, IBusinessEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey(nameof(Image))]
        public long? ImageId { get; set; }
        public Image Image { get; set; }
    }
}
