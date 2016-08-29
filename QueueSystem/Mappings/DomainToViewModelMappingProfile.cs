﻿using AutoMapper;
using QueueSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QueueSystem.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName => "DomainToViewModelMappings";

        protected override void Configure()
        {
            Mapper.CreateMap<HeThongSo, HeThongSoViewModels>()
                .ForMember(vm => vm.ID, map => map.MapFrom(m => m.ID))
                .ForMember(vm => vm.ManHinhID, map => map.MapFrom(m => m.ManHinhID))
                .ForMember(vm => vm.TenManHinh, map => map.MapFrom(m => m.ManHinh.ManHinhSo))
                .ForMember(vm => vm.Goi, map => map.MapFrom(m => m.Goi))
                .ForMember(vm => vm.STT, map => map.MapFrom(m => m.STT))
                .ForMember(vm => vm.STTConfirmed, map => map.MapFrom(m => m.STTConfirmed));
            Mapper.CreateMap<PortInfomaitonElectric, PortInfomaitonElectricViewModels>()
                .ForMember(vm => vm.ID, map => map.MapFrom(m => m.ID))
                .ForMember(vm => vm.Email, map => map.MapFrom(m => m.User.Email))
                .ForMember(vm => vm.IsPublic, map => map.MapFrom(m => m.IsPublic))
                .ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name))
                .ForMember(vm => vm.Phone, map => map.MapFrom(m => m.Phone))
                .ForMember(vm => vm.Url, map => map.MapFrom(m => m.Url));
        }
    }
}