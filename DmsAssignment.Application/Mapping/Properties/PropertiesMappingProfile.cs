using AutoMapper;
using DmsAssignment.Application.Feature.Properties.Commands.Models;
using DmsAssignment.Application.Feature.Properties.Queries.Response;
using DmsAssignment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmsAssignment.Application.Mapping.Properties
{
    public class PropertiesMappingProfile : Profile
    {
        public PropertiesMappingProfile() {
            //mapping the Device to the Query Models Response
            CreateMap<Device, GetPropertyListResponse>();
            CreateMap<Device, GetPropertyResponse>();
            CreateMap<AddPropertyCommand, Device>();
            CreateMap<UpdatePropertyCommand, Device>();

        }
    }

        }