using DmsAssignment.Domain.Entities;
using DmsAssignment.Application.IServices;
using DmsAssignment.Infrastructure.Repositories.PropertyRepositories;

namespace DmsAssignment.Application.Services
{
    public class PropertyTypeService : IPropertyTypeService
    {
        #region CTOR
        private readonly IPropertyTypeRepository _propertyTypeRepository;
        public PropertyTypeService(IPropertyTypeRepository propertyTypeRepository)
        {
            _propertyTypeRepository = propertyTypeRepository;
        }
        #endregion

        public async Task<string> AddPropertyTypeAsync(PropertyType propertyType)
        {
            return await _propertyTypeRepository.CreateAsync(propertyType);
        }

        public async Task<string> DeletePropertyTypeAsync(int id)
        {
            return await _propertyTypeRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<PropertyType>> GetAllPropertyTypesAsync()
        {
            return await _propertyTypeRepository.GetAllAsync();
        }

        public async Task<PropertyType> GetPropertyTypeByIdAsync(int id)
        {
            return await _propertyTypeRepository.GetByIdAsync(id);
        }

        public async Task<PropertyType> UpdatePropertyTypeAsync(PropertyType propertyType)
        {
            return await _propertyTypeRepository.UpdateAsync(propertyType);
        }
    }
}
