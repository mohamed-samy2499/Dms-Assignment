using DmsAssignment.Domain.Entities;
using DmsAssignment.Infrastructure.Generic;


namespace DmsAssignment.Infrastructure.Repositories.DeviceCategoryPropertyRepositories
{
    public interface IDeviceCategoryPropertyRepository : IGenericRepository<DeviceCategoryProperty>
    {
        Task<DeviceCategoryProperty> FindByCompositeKey(int deviceCategoryId, int propertyId);
        Task<string> DeleteRelationAsync(int deviceCategoryId, int propertyId);

    }
}
