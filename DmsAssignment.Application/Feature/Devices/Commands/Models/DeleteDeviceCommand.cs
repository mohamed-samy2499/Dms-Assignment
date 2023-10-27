using MediatR;
using DmsAssignment.Application.Bases;

namespace DmsAssignment.Application.Feature.Devices.Commands.Models
{
    public class DeleteDeviceCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
    }
}
