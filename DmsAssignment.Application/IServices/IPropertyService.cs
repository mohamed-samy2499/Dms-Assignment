using DmsAssignment.Domain.Entities;

namespace DmsAssignment.Application.IServices
{
    public interface IPropertyService
    {
        Task<IEnumerable<Property>> GetAllPropertiesAsync();
        Task<Property> GetPropertyByIdAsync(int id);

        Task<string> AddPropertyAsync(Property Dto);
        Task<Property> UpdatePropertyAsync(Property Dto);
        Task<string> DeletePropertyAsync(int id);
    }
}
