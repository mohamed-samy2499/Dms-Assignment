using MediatR;
using DmsAssignment.Application.Bases;
using DmsAssignment.Application.Feature.Devices.Queries.Response;

namespace DmsAssignment.Application.Feature.Devices.Queries.Models
{
    public class GetDeviceListQuery : IRequest<Response<IEnumerable<GetDeviceListResponse>>>
    {
    }
}
