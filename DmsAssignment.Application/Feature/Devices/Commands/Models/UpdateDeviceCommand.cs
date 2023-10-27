using MediatR;
using DmsAssignment.Domain.Entities;
using DmsAssignment.Application.Bases;
using DmsAssignment.Application.Feature.Devices.Queries.Response;

namespace DmsAssignment.Application.Feature.Devices.Commands.Models
{
    public class UpdateDeviceCommand : IRequest<Response<GetDeviceResponse>>
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string SerialNo { get; set; } = null!;

        public DateTime AcquisitionDate { get; set; }
        public string Memo { get; set; } = null!;


        // ---------- relations -----------
        public List<DevicePropertyCommand> Properties { get; set; } = null!;
    }
}
