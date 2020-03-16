﻿using AutoMapper;
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
            CreateMap<DeviceInputModel, Device>();
            CreateMap<DeviceUpdateModel, Device>();
        }

        private void ModelToDeviceType()
        {
            CreateMap<DeviceTypeInputModel, DeviceType>();
            CreateMap<DeviceTypeUpdateModel, DeviceType>();
        }

        private void ModelToCategory()
        {
            CreateMap<CategoryInputModel, Category>();
            CreateMap<CategoryUpdateModel, Category>();
        }

        private void ModelToProducer()
        {
            CreateMap<ProducerInputModel, Producer>()
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dst => dst.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dst => dst.RowVersion, opt => opt.Ignore());

            CreateMap<ProducerUpdateModel, Producer>()
                .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dst => dst.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dst => dst.RowVersion, opt => opt.MapFrom(src => src.RowVersion));
        }
    }
}
