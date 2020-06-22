using HomeAutomation.Models.DTO.Interfaces;

namespace HomeAutomation.Models.DTO.Abstract
{
    public class BaseModel : IBaseModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}
