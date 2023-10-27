using AutoMapper;
using MediatR;
using DmsAssignment.Domain.Entities;
using DmsAssignment.Application.Bases;
using DmsAssignment.Application.Feature.Properties.Commands.Models;
using DmsAssignment.Application.IServices;
using DmsAssignment.Application.Feature.Properties.Queries.Response;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using DmsAssignment.Infrastructure.Repositories.DeviceRepositories;
using DmsAssignment.Infrastructure.Repositories.DevicePropertyValueRepositories;

namespace DmsAssignment.Application.Feature.Properties.Commands.Handlers
{
    public class PropertyCommandHandler : ResponseHandler, IRequestHandler<AddPropertyCommand, Response<string>>,
                                      IRequestHandler<UpdatePropertyCommand, Response<GetPropertyResponse>>,
                                      IRequestHandler<DeletePropertyCommand, Response<string>>
    {
        #region CTOR
        private IPropertyService _propertyService;
        private IMapper _mapper;

        public PropertyCommandHandler(IPropertyService propertyService, IMapper mapper)
        {
            _propertyService = propertyService;
            _mapper = mapper;
        }
        #endregion
        public async Task<Response<string>> Handle(AddPropertyCommand request, CancellationToken cancellationToken)
        {
            var property = _mapper.Map<Property>(request);
            var result = await _propertyService.AddPropertyAsync(property);
            if (result != "success") { return BadRequest<string>(""); }
            else { return Created(""); }

        }
        public async Task<Response<GetPropertyResponse>> Handle(UpdatePropertyCommand request, CancellationToken cancellationToken)
        {
            // Retrieve the existing device by its ID.
            var existingProperty = await _propertyService.GetPropertyByIdAsync(request.Id);

            if (existingProperty == null)
            {
                // Handle the case where the device doesn't exist.
                return BadRequest<GetPropertyResponse>("Property not found");
            }

            // Update the device properties with values from the command.
            existingProperty.Name = request.Name;
         
            var result = await _propertyService.UpdatePropertyAsync(existingProperty);
            if (result == null) { return BadRequest<GetPropertyResponse>(""); }
            else {
                var resultDto = _mapper.Map<GetPropertyResponse>(result);
                return Success<GetPropertyResponse>(resultDto); 
            }

        }
        public async Task<Response<string>> Handle(DeletePropertyCommand request, CancellationToken cancellationToken)
        {
            var result = await _propertyService.DeletePropertyAsync(request.Id);
            if (result != "success") { return BadRequest<string>(""); }
            else { return Deleted<string>(result); }


        }
    }
}
