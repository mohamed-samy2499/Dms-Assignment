using AutoMapper;
using MediatR;
using DmsAssignment.Domain.Entities;
using DmsAssignment.Application.Bases;
using DmsAssignment.Application.Feature.Devices.Commands.Models;
using DmsAssignment.Application.IServices;
using DmsAssignment.Application.Feature.Devices.Queries.Response;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using DmsAssignment.Infrastructure.Repositories.DeviceRepositories;
using DmsAssignment.Infrastructure.Repositories.DevicePropertyValueRepositories;

namespace DmsAssignment.Application.Feature.Devices.Commands.Handlers
{
    public class DeviceCommandHandler : ResponseHandler, IRequestHandler<AddDeviceCommand, Response<string>>,
                                      IRequestHandler<UpdateDeviceCommand, Response<GetDeviceResponse>>,
                                      IRequestHandler<DeleteDeviceCommand, Response<string>>
    {
        #region CTOR
        private readonly IDevicePropertyValueRepository _devicePropertyValueRepository;
        private IDeviceService _deviceService;
        private IMapper _mapper;

        public DeviceCommandHandler(IDeviceService deviceService, IMapper mapper, IDevicePropertyValueRepository devicePropertyValueRepository)
        {
            _deviceService = deviceService;
            _mapper = mapper;
            _devicePropertyValueRepository = devicePropertyValueRepository;
        }
        #endregion
        public async Task<Response<string>> Handle(AddDeviceCommand request, CancellationToken cancellationToken)
        {
            var device = _mapper.Map<Device>(request);
            var result = await _deviceService.AddDeviceAsync(device);

            if (result != "success")
            {
                return BadRequest<string>("");
            }
            // Handle properties and values here
            foreach (var propertyCommand in request.Properties)
            {
                var devicePropertyValue = new DevicePropertyValue
                {
                    DeviceId = device.Id,
                    PropertyId = propertyCommand.PropertyId,
                    Value = propertyCommand.Value
                };
                await _devicePropertyValueRepository.CreateAsync(devicePropertyValue);
            }

            var result1 = await _deviceService.UpdateDeviceAsync(device);
            if (result1 == null) { return BadRequest<string>(""); }
            else { return Created(""); }

        }
        public async Task<Response<GetDeviceResponse>> Handle(UpdateDeviceCommand request, CancellationToken cancellationToken)
        {
            // Retrieve the existing device by its ID.
            var existingDevice = await _deviceService.GetDeviceByIdAsync(request.Id);

            if (existingDevice == null)
            {
                // Handle the case where the device doesn't exist.
                return BadRequest<GetDeviceResponse>("Device not found");
            }

            // Update the device properties with values from the command.
            existingDevice.Name = request.Name;
            existingDevice.SerialNo = request.SerialNo;
            existingDevice.AcquisitionDate = request.AcquisitionDate;
            existingDevice.Memo = request.Memo;

            // Update other properties as needed.

            // Update the device properties and values.
            foreach (var updatedProperty in request.Properties)
            {
                // Check if the device already has a property value for the updated property.
                var existingPropertyValue = existingDevice.DevicePropertyValues.FirstOrDefault(dpv => dpv.PropertyId == updatedProperty.PropertyId);

                if (existingPropertyValue != null)
                {
                    // Update the value of the existing property value.
                    existingPropertyValue.Value = updatedProperty.Value;
                }
                else
                {
                    // Create a new property value if it doesn't exist.
                    var newPropertyValue = new DevicePropertyValue
                    {
                        DeviceId = existingDevice.Id,
                        PropertyId = updatedProperty.PropertyId,
                        Value = updatedProperty.Value
                    };

                    // Add the new property value to the device's collection.
                    await _devicePropertyValueRepository.CreateAsync(newPropertyValue);
                }
            }
            var result = await _deviceService.UpdateDeviceAsync(existingDevice);
            if (result == null) { return BadRequest<GetDeviceResponse>(""); }
            else {
                var resultDto = _mapper.Map<GetDeviceResponse>(result);
                return Success<GetDeviceResponse>(resultDto); 
            }

        }
        public async Task<Response<string>> Handle(DeleteDeviceCommand request, CancellationToken cancellationToken)
        {
            var result = await _deviceService.DeleteDeviceAsync(request.Id);
            if (result != "success") { return BadRequest<string>(""); }
            else { return Deleted<string>(result); }


        }
    }
}
