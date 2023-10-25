using DmsAssignment.Domain.Entities;

namespace DmsAssignment.Application.IServices
{
    public interface IDeviceCategoryService
    {
        Task<IEnumerable<DeviceCategory>> GetAllDeviceCategoriesAsync();
        Task<DeviceCategory> GetDeviceCategoryByIdAsync(int id);

        Task<string> AddDeviceCategoryAsync(DeviceCategory Dto);
        Task<DeviceCategory> UpdateDeviceCategoryAsync(DeviceCategory Dto);
        Task<string> DeleteDeviceCategoryAsync(int id);

    }
}
