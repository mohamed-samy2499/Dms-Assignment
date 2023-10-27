using Microsoft.EntityFrameworkCore;
using DmsAssignment.Domain.Entities;
using DmsAssignment.Infrastructure.Database;
using DmsAssignment.Infrastructure.Generic;

namespace DmsAssignment.Infrastructure.Repositories.DeviceRepositories
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        #region CTOR
        private DbSet<Device> _device;
        public DeviceRepository(AppDbContext _appDbContext) : base(_appDbContext)
        {
            _device = _appDbContext.Set<Device>();
        }
        #endregion
        public async Task<Device> GetDeviceRelationsById(int Id)
        {
            var device =   _device.Include(d => d.DeviceCategory).Include(dp => dp.DevicePropertyValues)
                            .ThenInclude(dpv => dpv.Property).FirstOrDefault();
            return device;
        }
    }
}
