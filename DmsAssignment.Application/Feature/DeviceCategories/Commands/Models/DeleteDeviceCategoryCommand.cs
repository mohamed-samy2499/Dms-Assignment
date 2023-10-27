using MediatR;
using DmsAssignment.Application.Bases;

namespace DmsAssignment.Application.Feature.DeviceCategories.Commands.Models
{
    public class DeleteDeviceCategoryCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
    }
}
