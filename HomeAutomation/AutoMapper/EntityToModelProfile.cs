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
            CreateMap<Device, DeviceEditModel>();
            CreateMap<Device, DeviceListingModel>()
                .ForMember(dst => dst.ImageUrl, opt => opt.MapFrom(src => src.Image.FilePath));
        }

        private void DeviceTypeToModel()
        {
            CreateMap<DeviceType, DeviceTypeBaseModel>();
            CreateMap<DeviceType, DeviceTypeEditModel>();
            CreateMap<DeviceType, DeviceTypeListingModel>()
                .ForMember(dst => dst.ImageUrl, opt => opt.MapFrom(src => src.Image.FilePath));
        }

        private void CategoryToModel()
        {
            CreateMap<Category, CategoryBaseModel>();
            CreateMap<Category, CategoryEditModel>();
            CreateMap<Category, CategoryListingModel>()
                .ForMember(dst => dst.ImageUrl, opt => opt.MapFrom(src => src.Image.FilePath));
        }

        private void ProducerToModel()
        {
            CreateMap<Producer, ProducerBaseModel>();
            CreateMap<Producer, ProducerEditModel>();
            CreateMap<Producer, ProducerListingModel>()
                .ForMember(dst => dst.ImageUrl, opt => opt.MapFrom(src => src.Image.FilePath));
        }

        private void EntitiesToLookupModel()
        {
            CreateMap<Category, LookupModel>()
                .ForMember(dst => dst.Value, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.Label, opt => opt.MapFrom(src => src.Name));

            CreateMap<DeviceType, LookupModel>()
                .ForMember(dst => dst.Value, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.Label, opt => opt.MapFrom(src => src.Name));

            CreateMap<Producer, LookupModel>()
                .ForMember(dst => dst.Value, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.Label, opt => opt.MapFrom(src => src.Name));
        }
    }
}