using DmsAssignment.Domain.Entities;
using DmsAssignment.Application.IServices;
using DmsAssignment.Infrastructure.Repositories.PropertyRepositories;

namespace DmsAssignment.Application.Services
{
    public class PropertyService : IPropertyService
    {
        #region CTOR
        private readonly IPropertyRepository _propertyRepository;
        public PropertyService(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }
        #endregion

        public async Task<string> AddPropertyAsync(Property property)
        {
            return await _propertyRepository.CreateAsync(property);
        }

        public async Task<string> DeletePropertyAsync(int id)
        {
            return await _propertyRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Property>> GetAllPropertiesAsync()
        {
            return await _propertyRepository.GetAllAsync();
        }

        public async Task<Property> GetPropertyByIdAsync(int id)
        {
            return await _propertyRepository.GetByIdAsync(id);
        }

        public async Task<Property> UpdatePropertyAsync(Property property)
        {
            return await _propertyRepository.UpdateAsync(property);
        }
    }
}
