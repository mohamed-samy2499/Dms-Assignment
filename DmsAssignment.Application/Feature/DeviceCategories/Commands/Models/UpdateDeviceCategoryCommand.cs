using MediatR;
using DmsAssignment.Domain.Entities;
using DmsAssignment.Application.Bases;
using DmsAssignment.Application.Feature.DeviceCategories.Queries.Response;

namespace DmsAssignment.Application.Feature.DeviceCategories.Commands.Models
{
    public class UpdateDeviceCategoryCommand : IRequest<Response<GetDeviceCategoryResponse>>
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;


        // ---------- relations -----------
        public List<DeviceCategoryPropertyDto> Properties { get; set; } = null!;
    }
}
