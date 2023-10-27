using AutoMapper;
using DmsAssignment.Application.Feature.Devices.Commands.Models;
using DmsAssignment.Application.Feature.Devices.Queries.Response;
using DmsAssignment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmsAssignment.Application.Mapping.Devices
{
    public class DeviceCategoriesMappingProfile : Profile
    {
        public DeviceCategoriesMappingProfile() { 
            //mapping the Device to the Query Models Response
            CreateMap<Device, GetDeviceListResponse>()
                    .ForMember(dest => dest.DeviceCategoryName, opt => opt.MapFrom(src => src.DeviceCategory.Name));
            CreateMap<Device, GetDeviceResponse>()
                    .ForMember(dest => dest.DeviceCategoryName, opt => opt.MapFrom(src => src.DeviceCategory.Name))
                    .ForMember(dest => dest.PropertiesWithValues,
                    opt => opt.MapFrom(src => src.DevicePropertyValues.ToDictionary(k => k.Property.Name, v => v.Value)));
            CreateMap<AddDeviceCommand, Device>();
            CreateMap<UpdateDeviceCommand, Device>();

        }
    }

        }