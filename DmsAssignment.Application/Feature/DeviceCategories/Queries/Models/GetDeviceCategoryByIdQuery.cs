using MediatR;
using DmsAssignment.Application.Bases;
using DmsAssignment.Application.Feature.DeviceCategories.Queries.Response;

namespace DmsAssignment.Application.Feature.DeviceCategories.Queries.Models
{
    public class GetDeviceCategoryByIdQuery : IRequest<Response<GetDeviceCategoryResponse>>
    {
        public int Id { get; set; }
    }
}
