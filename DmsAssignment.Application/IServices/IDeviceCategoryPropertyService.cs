using DmsAssignment.Domain.Entities;

namespace DmsAssignment.Application.IServices
{
    public interface IDeviceCategoryPropertyService
    {
        Task<IEnumerable<DeviceCategoryProperty>> GetAllDeviceCategoryPropertiesAsync();
        Task<DeviceCategoryProperty> GetDeviceCategoryPropertyByIdAsync(int id);

        Task<string> AddDeviceCategoryPropertyAsync(DeviceCategoryProperty Dto);
        Task<DeviceCategoryProperty> UpdateDeviceCategoryPropertyAsync(DeviceCategoryProperty Dto);
        Task<string> DeleteDeviceCategoryPropertyAsync(int id);
    }
}
