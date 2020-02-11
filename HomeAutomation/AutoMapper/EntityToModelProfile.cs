using AutoMapper;
using HomeAutomation.Models.DTO;
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

        }

        private void DeviceTypeToModel()
        {

        }

        private void CategoryToModel()
        {

        }

        private void ProducerToModel()
        {
            CreateMap<Producer, ProducerModel>()
                .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name));
        }
    }
}

//.ForMember(dst => dst., opt => opt.MapFrom(src => src.))