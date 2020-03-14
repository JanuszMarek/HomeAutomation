using HomeAutomation.Models.DTO.Interfaces;

namespace HomeAutomation.Models.DTO.Producer
{
    public class ProducerModel : IBaseModel
    {
        public long Id { get; set; }

        public string Name { get; set; }
    }
}
