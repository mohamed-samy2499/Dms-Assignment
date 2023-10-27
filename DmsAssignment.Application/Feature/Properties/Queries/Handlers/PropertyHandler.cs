using AutoMapper;
using MediatR;
using DmsAssignment.Application.Bases;
using DmsAssignment.Application.Feature.Properties.Queries.Models;
using DmsAssignment.Application.Feature.Properties.Queries.Response;
using DmsAssignment.Application.IServices;

namespace DmsAssignment.Application.Feature.Properties.Queries.Handlers
{
    public class PropertyHandler : ResponseHandler,
                               IRequestHandler<GetPropertyListQuery, Response<IEnumerable<GetPropertyListResponse>>>,
                               IRequestHandler<GetPropertyByIdQuery, Response<GetPropertyResponse>>
    {
        #region CTOR
        private IPropertyService _propertyService;
        private IMapper _mapper;

        public PropertyHandler(IPropertyService propertyService, IMapper mapper)
        {
            _propertyService = propertyService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<IEnumerable<GetPropertyListResponse>>> Handle(GetPropertyListQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _propertyService.GetAllPropertiesAsync();

            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetPropertyListResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetPropertyListResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }
        }

        public async Task<Response<GetPropertyResponse>> Handle(GetPropertyByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _propertyService.GetPropertyByIdAsync(request.Id);

            if (entity == null)
            {
                return NotFound<GetPropertyResponse>("Sorry, There is no data to display!");
            }
            else
            {
                var entityMapped = _mapper.Map<GetPropertyResponse>(entity);


                return Success(entityMapped);
            }


        }

      
        
    }
}
