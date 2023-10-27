using DmsAssignment.Domain.Entities;
using DmsAssignment.Application.IServices;
using DmsAssignment.Infrastructure.Repositories.DeviceRepositories;
using System.Linq.Expressions;

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
            var includes = new Expression<Func<Device, object>>[] {
                device => device.DeviceCategory
            };

            return await _deviceRepository.GetAllAsync(includes);
        }

        public async Task<Device> GetDeviceByIdAsync(int id)
        {
            var includes = new Expression<Func<Device, object>>[] {
                device => device.DeviceCategory , device => device.DevicePropertyValues
            };
            return await _deviceRepository.GetByIdAsync(id,includes);
        }

        public async Task<Device> UpdateDeviceAsync(Device device)
        {
            return await _deviceRepository.UpdateAsync(device);
        }
      
    }
}
