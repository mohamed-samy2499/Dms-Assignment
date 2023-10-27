using AutoMapper;
using MediatR;
using DmsAssignment.Application.Bases;
using DmsAssignment.Application.Feature.Devices.Queries.Models;
using DmsAssignment.Application.Feature.Devices.Queries.Response;
using DmsAssignment.Application.IServices;

namespace DmsAssignment.Application.Feature.Devices.Queries.Handlers
{
    public class DeviceCategoryHandler : ResponseHandler,
                               IRequestHandler<GetDeviceListQuery, Response<IEnumerable<GetDeviceListResponse>>>,
                               IRequestHandler<GetDeviceByIdQuery, Response<GetDeviceResponse>>
    {
        #region CTOR
        private IDeviceService _deviceService;
        private IMapper _mapper;

        public DeviceCategoryHandler(IDeviceService deviceService, IMapper mapper)
        {
            _deviceService = deviceService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<IEnumerable<GetDeviceListResponse>>> Handle(GetDeviceListQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _deviceService.GetAllDevicesAsync();

            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetDeviceListResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetDeviceListResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }
        }

        public async Task<Response<GetDeviceResponse>> Handle(GetDeviceByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _deviceService.GetDeviceByIdAsync(request.Id);

            if (entity == null)
            {
                return NotFound<GetDeviceResponse>("Sorry, There is no data to display!");
            }
            else
            {

                var entityMapped = _mapper.Map<GetDeviceResponse>(entity);


                return Success(entityMapped);
            }


        }

      
        
    }
}
