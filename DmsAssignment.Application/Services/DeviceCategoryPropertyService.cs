using DmsAssignment.Domain.Entities;
using DmsAssignment.Application.IServices;
using DmsAssignment.Infrastructure.Repositories.DeviceCategoryPropertyRepositories;

namespace DmsAssignment.Application.Services
{
    public class DeviceCategoryPropertyService : IDeviceCategoryPropertyService
    {
        #region CTOR
        private readonly IDeviceCategoryPropertyRepository _deviceCategoryPropertyRepository;
        public DeviceCategoryPropertyService(IDeviceCategoryPropertyRepository deviceCategoryPropertyRepository)
        {
            _deviceCategoryPropertyRepository = deviceCategoryPropertyRepository;
        }
        #endregion

        public async Task<string> AddDeviceCategoryPropertyAsync(DeviceCategoryProperty deviceCategory)
        {
            return await _deviceCategoryPropertyRepository.CreateAsync(deviceCategory);
        }

        public async Task<string> DeleteDeviceCategoryPropertyAsync(int id)
        {
            return await _deviceCategoryPropertyRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<DeviceCategoryProperty>> GetAllDeviceCategoryPropertiesAsync()
        {
            return await _deviceCategoryPropertyRepository.GetAllAsync();
        }

        public async Task<DeviceCategoryProperty> GetDeviceCategoryPropertyByIdAsync(int id)
        {
            return await _deviceCategoryPropertyRepository.GetByIdAsync(id);
        }

        public async Task<DeviceCategoryProperty> UpdateDeviceCategoryPropertyAsync(DeviceCategoryProperty deviceCategory)
        {
            return await _deviceCategoryPropertyRepository.UpdateAsync(deviceCategory);
        }
    }
}
