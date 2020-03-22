using AutoMapper;
using HomeAutomation.Models.DTO;
using HomeAutomation.Models.DTO.Category;
using HomeAutomation.Models.DTO.Device;
using HomeAutomation.Models.DTO.DeviceType;
using HomeAutomation.Models.DTO.Producer;
using HomeAutomation.Models.Entities;

namespace HomeAutomation.AutoMapper
{
    public class EntityToModelProfile: Profile
    {
        public EntityToModelProfile()
        {
            DeviceToModel();
            DeviceTypeToModel();
            CategoryToModel();
            ProducerToModel();
            EntitiesToLookupModel();
        }

        private void DeviceToModel()
        {
            CreateMap<Device, DeviceBaseModel>();
            CreateMap<Device, DeviceModel>();
            CreateMap<Device, DeviceListingModel>();
            CreateMap<Device, DeviceEditModel>();
        }

        private void DeviceTypeToModel()
        {
            CreateMap<DeviceType, DeviceTypeBaseModel>();
            CreateMap<DeviceType, DeviceTypeModel>();
            CreateMap<DeviceType, DeviceTypeListingModel>();
            CreateMap<DeviceType, DeviceTypeEditModel>();
        }

        private void CategoryToModel()
        {
            CreateMap<Category, CategoryBaseModel>();
            CreateMap<Category, CategoryModel>();
            CreateMap<Category, CategoryListingModel>();
            CreateMap<Category, CategoryEditModel>();
        }

        private void ProducerToModel()
        {
            CreateMap<Producer, ProducerBaseModel>();
            CreateMap<Producer, ProducerModel>();
            CreateMap<Producer, ProducerListingModel>();
            CreateMap<Producer, ProducerEditModel>();
        }

        private void EntitiesToLookupModel()
        {
            CreateMap<Category, LookupModel>()
                .ForMember(dst => dst.Value, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.Label, opt => opt.MapFrom(src => src.Name));

            CreateMap<DeviceType, LookupModel>()
                .ForMember(dst => dst.Value, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.Label, opt => opt.MapFrom(src => src.Name));
        }
    }
}