using DmsAssignment.Domain.Entities;
using DmsAssignment.Infrastructure.Generic;
using Microsoft.EntityFrameworkCore;
using DmsAssignment.Infrastructure.Database;
using DmsAssignment.Infrastructure.Repositories.DeviceCategoryRepositories;

namespace DmsAssignment.Infrastructure.Repositories.DeviceCategoryPropertyRepositories
{
    public class DeviceCategoryPropertyRepository : GenericRepository<DeviceCategoryProperty>, IDeviceCategoryPropertyRepository
    {
        #region CTOR
        private DbSet<DeviceCategoryProperty> _deviceCategoryProperty;

        public DeviceCategoryPropertyRepository(AppDbContext _appDbContext) : base(_appDbContext)
        {
            _deviceCategoryProperty = _appDbContext.Set<DeviceCategoryProperty>();
        }

        public async Task<DeviceCategoryProperty> FindByCompositeKey(int deviceCategoryId, int propertyId)
        {
            var item =  _deviceCategoryProperty.Where(dcp => dcp.DeviceCategoryId == deviceCategoryId 
            && dcp.PropertyId ==  propertyId).IgnoreQueryFilters().FirstOrDefault();  
            return item;
            throw new NotImplementedException();
        }
        public async Task<string> DeleteRelationAsync(int deviceCategoryId, int propertyId)
        {
            var entity = _deviceCategoryProperty.Where(dcp => dcp.DeviceCategoryId == deviceCategoryId
            && dcp.PropertyId == propertyId).FirstOrDefault();
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DateDeleted = DateTime.Now;
                //_appDbContext.Entry(entity).State = EntityState.Deleted;
                await UpdateAsync(entity);
                return "success";
            }
            return "Fails";
            throw new NotImplementedException();
        }
        #endregion
    }
}
