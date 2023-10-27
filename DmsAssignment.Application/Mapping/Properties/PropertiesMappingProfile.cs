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
            CreateMap<Property, GetPropertyListResponse>();
            CreateMap<Property, GetPropertyResponse>();
            CreateMap<AddPropertyCommand, Property>();
            CreateMap<UpdatePropertyCommand, Property>();
            CreateMap<GetPropertyResponse, UpdatePropertyCommand>();


        }
    }

        }