using DmsAssignment.Domain.Entities;
using DmsAssignment.Application.IServices;
using DmsAssignment.Infrastructure.Repositories.DeviceRepositories;
using DmsAssignment.Infrastructure.Repositories.DevicePropertyValueRepositories;

namespace DmsAssignment.Application.Services
{
    public class DevicePropertyValueService : IDevicePropertyValueService
    {
        #region CTOR
        private readonly IDevicePropertyValueRepository _devicePropertyValueRepository;
        public DevicePropertyValueService(IDevicePropertyValueRepository devicePropertyValueRepository)
        {
            _devicePropertyValueRepository = devicePropertyValueRepository;
        }
        #endregion

        public async Task<string> AddDevicePropertyValueAsync(DevicePropertyValue devicePropertyValue)
        {
            return await _devicePropertyValueRepository.CreateAsync(devicePropertyValue);
        }

        public async Task<string> DeleteDevicePropertyValueAsync(int id)
        {
            return await _devicePropertyValueRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<DevicePropertyValue>> GetAllDevicePropertyValuesAsync()
        {
            return await _devicePropertyValueRepository.GetAllAsync();
        }

        public async Task<DevicePropertyValue> GetDevicePropertyValueByIdAsync(int id)
        {
            return await _devicePropertyValueRepository.GetByIdAsync(id);
        }

        public async Task<DevicePropertyValue> UpdateDevicePropertyValueAsync(DevicePropertyValue devicePropertyValue)
        {
            return await _devicePropertyValueRepository.UpdateAsync(devicePropertyValue);
        }
    }
}
