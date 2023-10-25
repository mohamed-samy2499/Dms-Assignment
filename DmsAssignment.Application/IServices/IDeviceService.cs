using DmsAssignment.Domain.Entities;

namespace DmsAssignment.Application.IServices
{
    public interface IDeviceService
    {
        Task<IEnumerable<Device>> GetAllDevicesAsync();
        Task<Device> GetDeviceByIdAsync(int id);

        Task<string> AddDeviceAsync(Device Dto);
        Task<Device> UpdateDeviceAsync(Device Dto);
        Task<string> DeleteDeviceAsync(int id);
    }
}
