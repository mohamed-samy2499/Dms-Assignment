using AutoMapper;
using DmsAssignment.Application.Feature.DeviceCategories.Commands.Models;
using DmsAssignment.Application.Feature.DeviceCategories.Queries.Response;
using DmsAssignment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmsAssignment.Application.Mapping.DeviceCategories
{
    public class DeviceCategoriesMappingProfile : Profile
    {
        public DeviceCategoriesMappingProfile() {
            //mapping the Device to the Query Models Response
            CreateMap<DeviceCategoryPropertyDto, Property>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.PropertyId))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.PropertyName)).ReverseMap();

            CreateMap<DeviceCategory, GetDeviceCategoryListResponse>();
            CreateMap<DeviceCategory, GetDeviceCategoryResponse>()
                 .ForMember(dest => dest.Properties, opt => opt.MapFrom(src => src.DeviceCategoryProperties.Select(dcp => new DeviceCategoryPropertyDto
                 {
                     PropertyId = dcp.PropertyId,
                     PropertyName = dcp.Property.Name
                 })));
            CreateMap<AddDeviceCategoryCommand, DeviceCategory>();
            CreateMap<UpdateDeviceCategoryCommand, DeviceCategory>();

        }
    }

        }