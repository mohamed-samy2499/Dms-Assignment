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
    }
}
