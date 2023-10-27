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

namespace MovieSystem.Application.Feature.Likes.Commands.Handlers
{
    public class DeviceCategoryCommandHandler : ResponseHandler, IRequestHandler<AddDeviceCategoryCommand, Response<string>>,
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
            // Add properties to the device category
            foreach (var propertyDto in request.Properties)
            {
                var property = _mapper.Map<Property>(propertyDto);
                var deviceCategoryProperty = new DeviceCategoryProperty()
                {
                    PropertyId = property.Id,
                    DeviceCategoryId = deviceCategory.Id
                };
                await _deviceCategoryPropertyRepository.CreateAsync(deviceCategoryProperty);
            }

            var result = await _deviceCategoryService.AddDeviceCategoryAsync(deviceCategory);
            if (result != "success") { return BadRequest<string>(""); }
            else { return Created(""); }

        }
        public async Task<Response<GetDeviceCategoryResponse>> Handle(UpdateDeviceCategoryCommand request, CancellationToken cancellationToken)
        {
            // Retrieve the existing device by its ID.
            var existingDeviceCategory = await _deviceCategoryService.GetDeviceCategoryByIdAsync(request.Id);

            if (existingDeviceCategory == null)
            {
                // Handle the case where the device doesn't exist.
                return BadRequest<GetDeviceCategoryResponse>("Device Category not found");
            }

            // Update the device properties with values from the command.
            existingDeviceCategory.Name = request.Name;

            // Update other properties as needed.
            // Update the device properties and values.
            foreach (var updatedProperty in request.Properties)
            {
                // Check if the device already has a property value for the updated property.
                var existingPropertyValue = existingDeviceCategory.DeviceCategoryProperties.FirstOrDefault(dpv => dpv.PropertyId == updatedProperty.PropertyId);

                if (existingPropertyValue != null)
                {
                    // Update the value of the existing property value.
                    var mappedProperty = _mapper.Map<Property>(updatedProperty);
                    existingPropertyValue.Property = mappedProperty;
                }
                else
                {
                    // Create a new property value if it doesn't exist.
                    var newDeviceCategoryProperty = new DeviceCategoryProperty
                    {
                        DeviceCategoryId = existingDeviceCategory.Id,
                        PropertyId = updatedProperty.PropertyId,
                    };

                    // Add the new property value to the device's collection.
                    await _deviceCategoryPropertyRepository.CreateAsync(newDeviceCategoryProperty);
                }
            }
            var result = await _deviceCategoryService.UpdateDeviceCategoryAsync(existingDeviceCategory);
            if (result == null) { return BadRequest<GetDeviceCategoryResponse>(""); }
            else {
                var resultDto = _mapper.Map<GetDeviceCategoryResponse>(result);
                return Success<GetDeviceCategoryResponse>(resultDto); 
            }

        }
        public async Task<Response<string>> Handle(DeleteDeviceCategoryCommand request, CancellationToken cancellationToken)
        {
            var result = await _deviceCategoryService.DeleteDeviceCategoryAsync(request.Id);
            if (result != "success") { return BadRequest<string>(""); }
            else { return Deleted<string>(result); }


        }
    }
}
