using AutoMapper;
using HomeAutomation.Models.DTO;
using HomeAutomation.Models.DTO.Category;
using HomeAutomation.Models.DTO.Device;
using HomeAutomation.Models.DTO.DeviceType;
using HomeAutomation.Models.DTO.Producer;
using HomeAutomation.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        }

        private void DeviceToModel()
        {
            CreateMap<Device, DeviceModel>()
                .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dst => dst.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dst => dst.DeviceTypeId, opt => opt.MapFrom(src => src.DeviceTypeId))
                .ForMember(dst => dst.ProducerId, opt => opt.MapFrom(src => src.ProducerId));
        }

        private void DeviceTypeToModel()
        {
            CreateMap<DeviceType, DeviceTypeModel>()
                .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dst => dst.CategoryId, opt => opt.MapFrom(src => src.CategoryId));
        }

        private void CategoryToModel()
        {
            CreateMap<Category, CategoryModel>()
                .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name));
        }

        private void ProducerToModel()
        {
            CreateMap<Producer, ProducerModel>()
                .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name));
        }
    }
}