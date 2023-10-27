using Microsoft.EntityFrameworkCore;
using DmsAssignment.Domain.Entities;
using DmsAssignment.Infrastructure.Database;
using DmsAssignment.Infrastructure.Generic;

namespace DmsAssignment.Infrastructure.Repositories.DeviceCategoryRepositories
{
    public class DeviceCategoryRepository : GenericRepository<DeviceCategory>, IDeviceCategoryRepository
    {
        #region CTOR
        private DbSet<DeviceCategory> _deviceCategory;

        public DeviceCategoryRepository(AppDbContext _appDbContext) : base(_appDbContext)
        {
            _deviceCategory = _appDbContext.Set<DeviceCategory>();
        }
        #endregion
        public async Task<DeviceCategory> GetDeviceCategoryPropertiesByIdAsync(int deviceCategoryId)
        {
            return await _deviceCategory
                .Include(dc => dc.DeviceCategoryProperties)
                .ThenInclude(dcp => dcp.Property) // Include the Property entity
                .FirstOrDefaultAsync(dc => dc.Id == deviceCategoryId);
        }
    }
}
