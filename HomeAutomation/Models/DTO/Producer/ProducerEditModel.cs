using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.DTO.Interfaces;

namespace HomeAutomation.Models.DTO.Producer
{
    public class ProducerEditModel : Concurrency, IBaseModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
