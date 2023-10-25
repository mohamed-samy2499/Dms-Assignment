using DmsAssignment.Domain.Entities;
using DmsAssignment.Application.IServices;
using DmsAssignment.Infrastructure.Repositories.DeviceRepositories;

namespace DmsAssignment.Application.Services
{
    public class DeviceService : IDeviceService
    {
        #region CTOR
        private readonly IDeviceRepository _deviceRepository;
        public DeviceService(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }
        #endregion

        public async Task<string> AddDeviceAsync(Device device)
        {
            return await _deviceRepository.CreateAsync(device);
        }

        public async Task<string> DeleteDeviceAsync(int id)
        {
            return await _deviceRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Device>> GetAllDevicesAsync()
        {
            return await _deviceRepository.GetAllAsync();
        }

        public async Task<Device> GetDeviceByIdAsync(int id)
        {
            return await _deviceRepository.GetByIdAsync(id);
        }

        public async Task<Device> UpdateDeviceAsync(Device device)
        {
            return await _deviceRepository.UpdateAsync(device);
        }
    }
}
