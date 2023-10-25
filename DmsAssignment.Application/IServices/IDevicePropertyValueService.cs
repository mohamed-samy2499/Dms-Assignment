using DmsAssignment.Domain.Entities;

namespace DmsAssignment.Application.IServices
{
    public interface IDevicePropertyValueService
    {
        Task<IEnumerable<DevicePropertyValue>> GetAllDevicePropertyValuesAsync();
        Task<DevicePropertyValue> GetDevicePropertyValueByIdAsync(int id);

        Task<string> AddDevicePropertyValueAsync(DevicePropertyValue Dto);
        Task<DevicePropertyValue> UpdateDevicePropertyValueAsync(DevicePropertyValue Dto);
        Task<string> DeleteDevicePropertyValueAsync(int id);
    }
}
