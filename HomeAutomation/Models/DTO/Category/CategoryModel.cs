using HomeAutomation.Models.DTO.Interfaces;

namespace HomeAutomation.Models.DTO.Category
{
    public class CategoryModel : IBaseModel
    {
        public long Id { get; set; }

        public string Name { get; set; }
    }
}
