using DmsAssignment.Application.Feature.DeviceCategories.Commands.Models;

namespace DmsAssignment.Application.Feature.DeviceCategories.Queries.Response
{
    public class GetDeviceCategoryResponse
    {
        public string Name { get; set; } = null!;

        // ---------- relations -----------
        public List<DeviceCategoryDeviceDto> DevicesNames { get; set; } = null!;
        public List<DeviceCategoryPropertyDto> Properties { get; set; } = null!;
    }
}
