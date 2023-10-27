using MediatR;
using DmsAssignment.Application.Bases;

namespace DmsAssignment.Application.Feature.Devices.Commands.Models
{
    public class AddDeviceCommand : IRequest<Response<string>>
    {
        public string Name { get; set; } = null!;
        public string SerialNo { get; set; } = null!;

        public DateTime AcquisitionDate { get; set; }
        public string Memo { get; set; } = null!;


        // ---------- relations -----------
        public int DeviceCategoryId { get; set; }
        public List<DevicePropertyCommand> Properties { get; set; } = null!;
    }
}
