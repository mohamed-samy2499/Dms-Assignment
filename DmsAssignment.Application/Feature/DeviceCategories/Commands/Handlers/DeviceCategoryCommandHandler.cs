using AutoMapper;
using MediatR;
using DmsAssignment.Domain.Entities;
using DmsAssignment.Application.Bases;
using DmsAssignment.Application.Feature.DeviceCategories.Commands.Models;
using DmsAssignment.Application.IServices;
using DmsAssignment.Application.Feature.DeviceCategories.Queries.Response;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using DmsAssignment.Infrastructure.Repositories.DeviceRepositories;
using DmsAssignment.Infrastructure.Repositories.DevicePropertyValueRepositories;
using DmsAssignment.Infrastructure.Repositories.DeviceCategoryPropertyRepositories;
using System.Runtime.InteropServices;

namespace DmsAssignment.Application.Feature.Likes.Commands.Handlers
{
    public class DeviceCategoryCommandHandler : ResponseHandler, IRequestHandler<AddDeviceCategoryCommand, Response<string>>,
                                                                //IRequestHandler<EditDeviceCategoryPropertiesCommand, Response<GetDeviceCategoryResponse>>,

                                                                IRequestHandler<UpdateDeviceCategoryCommand, Response<GetDeviceCategoryResponse>>,
                                                                IRequestHandler<DeleteDeviceCategoryCommand, Response<string>>
    {
        #region CTOR
        private readonly IDeviceCategoryPropertyRepository _deviceCategoryPropertyRepository;
        private IDeviceCategoryService _deviceCategoryService;
        private IMapper _mapper;

        public DeviceCategoryCommandHandler(IDeviceCategoryService deviceCategoryService, IMapper mapper,
            IDeviceCategoryPropertyRepository deviceCategoryPropertyRepository)
        {
            _deviceCategoryService = deviceCategoryService;
            _mapper = mapper;
            _deviceCategoryPropertyRepository = deviceCategoryPropertyRepository;
        }
        #endregion
        public async Task<Response<string>> Handle(AddDeviceCategoryCommand request, CancellationToken cancellationToken)
        {
            var deviceCategory = _mapper.Map<DeviceCategory>(request);

            var result = await _deviceCategoryService.AddDeviceCategoryAsync(deviceCategory);
            if (result != "success") { return BadRequest<string>(""); }
            else { return Created(""); }

        }
   

        public async Task<Response<GetDeviceCategoryResponse>> Handle(UpdateDeviceCategoryCommand request, CancellationToken cancellationToken)
        {
            var deviceCategory = await _deviceCategoryService.GetDeviceCategoryByIdAsync(request.Id);
            var mappedDeviceCategory = _mapper.Map<GetDeviceCategoryResponse>(deviceCategory); 
            var existingProperties = mappedDeviceCategory.Properties;
            // Add properties to the device category
            foreach (var propertyDto in request.Properties)
            {
                var itemToFind = new DeviceCategoryPropertyDto() { 
                PropertyId = propertyDto.PropertyId,
                PropertyName = propertyDto.PropertyName
                };
                itemToFind.IsSelected = false;
                bool alreadyExists = existingProperties.Contains(itemToFind, new DeviceCategoryPropertyDtoEqualityComparer());
                if (propertyDto.IsSelected && !alreadyExists)
                {
                    var deviceCategoryProperty = _deviceCategoryPropertyRepository
                        .FindByCompositeKey(request.Id, propertyDto.PropertyId).Result;
                    if(deviceCategoryProperty != null)
                    {
                        deviceCategoryProperty.IsDeleted = false;
                        var updateResult =  await _deviceCategoryPropertyRepository.UpdateAsync(deviceCategoryProperty);
                        if (updateResult == null) { return BadRequest<GetDeviceCategoryResponse>(""); }
                    }
                    else
                    {

                        var result = await _deviceCategoryPropertyRepository.CreateAsync(new DeviceCategoryProperty
                        {
                            PropertyId = propertyDto.PropertyId,
                            DeviceCategoryId = deviceCategory.Id
                        });
                        if (result != "success") { return BadRequest<GetDeviceCategoryResponse>(""); }
                    }
                }
                else if(!propertyDto.IsSelected && alreadyExists)
                {
                    
                 
                    var deleteResult = await _deviceCategoryPropertyRepository.DeleteRelationAsync(request.Id, propertyDto.PropertyId);
                    if (deleteResult != "success") { return BadRequest<GetDeviceCategoryResponse>(""); }
                }
            }
            var deviceCategoryAfter = await _deviceCategoryService.GetDeviceCategoryByIdAsync(request.Id);
            var MappedResult = _mapper.Map<GetDeviceCategoryResponse>(deviceCategoryAfter);
            return Success<GetDeviceCategoryResponse>(MappedResult);

        }
        public async Task<Response<string>> Handle(DeleteDeviceCategoryCommand request, CancellationToken cancellationToken)
        {
            var result = await _deviceCategoryService.DeleteDeviceCategoryAsync(request.Id);
            if (result != "success") { return BadRequest<string>(""); }
            else { return Deleted<string>(result); }


        }
    }
}
