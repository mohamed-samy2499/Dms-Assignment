using MediatR;
using DmsAssignment.Application.Bases;

namespace DmsAssignment.Application.Feature.DeviceCategories.Commands.Models
{
    public class AddDeviceCategoryCommand : IRequest<Response<string>>
    {
        public string Name { get; set; } = null!;
    }
}
