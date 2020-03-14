using AutoMapper;
using HomeAutomation.Models.DTO;
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

        }

        private void ModelToDeviceType()
        {

        }

        private void ModelToCategory()
        {

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
