using MediatR;
using DmsAssignment.Application.Bases;
using DmsAssignment.Application.Feature.DeviceCategories.Queries.Response;

namespace DmsAssignment.Application.Feature.DeviceCategories.Queries.Models
{
    public class GetDeviceCategoryListQuery : IRequest<Response<IEnumerable<GetDeviceCategoryListResponse>>>
    {
    }
}
