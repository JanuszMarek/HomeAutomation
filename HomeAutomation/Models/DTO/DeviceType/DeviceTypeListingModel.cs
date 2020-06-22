using HomeAutomation.Models.DTO.Category;

namespace HomeAutomation.Models.DTO.DeviceType
{
    public class DeviceTypeListingModel : DeviceTypeBaseModel
    {
        public CategoryBaseModel Category { get; set; }
    }
}
