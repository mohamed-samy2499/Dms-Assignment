using MediatR;
using DmsAssignment.Application.Bases;
using DmsAssignment.Application.Feature.Properties.Queries.Response;

namespace DmsAssignment.Application.Feature.Properties.Queries.Models
{
    public class GetPropertyListQuery : IRequest<Response<IEnumerable<GetPropertyListResponse>>>
    {
    }
}
