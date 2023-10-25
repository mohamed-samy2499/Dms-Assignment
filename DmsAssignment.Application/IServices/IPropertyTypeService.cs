using DmsAssignment.Domain.Entities;

namespace DmsAssignment.Application.IServices
{
    public interface IPropertyTypeService
    {
        Task<IEnumerable<PropertyType>> GetAllPropertyTypesAsync();
        Task<PropertyType> GetPropertyTypeByIdAsync(int id);

        Task<string> AddPropertyTypeAsync(PropertyType Dto);
        Task<PropertyType> UpdatePropertyTypeAsync(PropertyType Dto);
        Task<string> DeletePropertyTypeAsync(int id);
    }
}
