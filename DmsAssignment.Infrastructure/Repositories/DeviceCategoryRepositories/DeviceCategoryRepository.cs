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
        public async Task<DeviceCategory> GetDeviceCategoryRelationsById(int Id)
        {
            var deviceCategory = await _deviceCategory.Where(de => de.Id == Id).Include(d => d.Devices).Include(dp => dp.DeviceCategoryProperties)
                            .ThenInclude(dpv => dpv.Property).FirstOrDefaultAsync();
            return deviceCategory;
        }
    }
}
