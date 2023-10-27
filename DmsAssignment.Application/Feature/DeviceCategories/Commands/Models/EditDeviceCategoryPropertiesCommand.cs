using MediatR;
using DmsAssignment.Application.Bases;

namespace DmsAssignment.Application.Feature.DeviceCategories.Commands.Models
{
    public class EditDeviceCategoryPropertiesCommand : IRequest<Response<string>>
    {
        public int DeviceCategoryId { get; set; }


        // ---------- relations -----------
        public List<DeviceCategoryPropertyDto> Properties { get; set; } = null!;
    }
}
