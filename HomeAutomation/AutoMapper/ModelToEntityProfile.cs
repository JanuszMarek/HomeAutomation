using AutoMapper;
using HomeAutomation.Models.DTO.Category;
using HomeAutomation.Models.DTO.Device;
using HomeAutomation.Models.DTO.DeviceType;
using HomeAutomation.Models.DTO.Producer;
using HomeAutomation.Models.Entities;

namespace HomeAutomation.AutoMapper
{
    public class ModelToEntityProfile: Profile
    {
        
        public ModelToEntityProfile()
        {
            ModelToDevice();
            ModelToDeviceType();
            ModelToCategory();
            ModelToProducer();
        }

        private void ModelToDevice()
        {
            CreateMap<DeviceCreateModel, Device>();
        }

        private void ModelToDeviceType()
        {
            CreateMap<DeviceTypeCreateModel, DeviceType>();
        }

        private void ModelToCategory()
        {
            CreateMap<CategoryCreateModel, Category>();
        }

        private void ModelToProducer()
        {
            CreateMap<ProducerCreateModel, Producer>();
        }
    }
}
