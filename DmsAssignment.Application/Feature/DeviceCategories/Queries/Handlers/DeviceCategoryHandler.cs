using AutoMapper;
using MediatR;
using DmsAssignment.Application.Bases;
using DmsAssignment.Application.Feature.DeviceCategories.Queries.Models;
using DmsAssignment.Application.Feature.DeviceCategories.Queries.Response;
using DmsAssignment.Application.IServices;

namespace DmsAssignment.Application.Feature.DeviceCategories.Queries.Handlers
{
    public class DeviceCategoryHandler : ResponseHandler,
                               IRequestHandler<GetDeviceCategoryListQuery, Response<IEnumerable<GetDeviceCategoryListResponse>>>,
                               IRequestHandler<GetDeviceCategoryByIdQuery, Response<GetDeviceCategoryResponse>>
    {
        #region CTOR
        private IDeviceCategoryService _deviceCategoryService;
        private IMapper _mapper;

        public DeviceCategoryHandler(IDeviceCategoryService deviceCategoryService, IMapper mapper)
        {
            _deviceCategoryService = deviceCategoryService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<IEnumerable<GetDeviceCategoryListResponse>>> Handle(GetDeviceCategoryListQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _deviceCategoryService.GetAllDeviceCategoriesAsync();

            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetDeviceCategoryListResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetDeviceCategoryListResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }
        }

        public async Task<Response<GetDeviceCategoryResponse>> Handle(GetDeviceCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _deviceCategoryService.GetDeviceCategoryByIdAsync(request.Id);

            if (entity == null)
            {
                return NotFound<GetDeviceCategoryResponse>("Sorry, There is no data to display!");
            }
            else
            {
                var entityMapped = _mapper.Map<GetDeviceCategoryResponse>(entity);

                return Success(entityMapped);
            }


        }

      
        
    }
}
