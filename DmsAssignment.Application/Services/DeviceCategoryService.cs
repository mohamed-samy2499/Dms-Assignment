using DmsAssignment.Domain.Entities;
using DmsAssignment.Application.IServices;
using DmsAssignment.Infrastructure.Repositories.DeviceCategoryRepositories;

namespace DmsAssignment.Application.Services
{
    public class DeviceCategoryService : IDeviceCategoryService
    {
        #region CTOR
        private readonly IDeviceCategoryRepository _deviceCategoryRepository;
        public DeviceCategoryService(IDeviceCategoryRepository deviceCategoryRepository)
        {
            _deviceCategoryRepository = deviceCategoryRepository;
        }
        #endregion

        public async Task<string> AddDeviceCategoryAsync(DeviceCategory deviceCategory)
        {
            return await _deviceCategoryRepository.CreateAsync(deviceCategory);
        }

        public async Task<string> DeleteDeviceCategoryAsync(int id)
        {
            return await _deviceCategoryRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<DeviceCategory>> GetAllDeviceCategoriesAsync()
        {
            return await _deviceCategoryRepository.GetAllAsync();
        }

        public async Task<DeviceCategory> GetDeviceCategoryByIdAsync(int id)
        {
            return await _deviceCategoryRepository.GetByIdAsync(id);
        }

        public async Task<DeviceCategory> UpdateDeviceCategoryAsync(DeviceCategory deviceCategory)
        {
            return await _deviceCategoryRepository.UpdateAsync(deviceCategory);
        }
    }
}
