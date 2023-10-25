using Microsoft.EntityFrameworkCore;
using DmsAssignment.Domain.Entities;
using DmsAssignment.Infrastructure.Database;
using DmsAssignment.Infrastructure.Generic;

namespace DmsAssignment.Infrastructure.Repositories.DevicePropertyValueRepositories
{
    public class DevicePropertyValueRepository : GenericRepository<DevicePropertyValue>, IDevicePropertyValueRepository
    {
        #region CTOR
        private DbSet<DevicePropertyValue> _devicePropertyValue;
        public DevicePropertyValueRepository(AppDbContext _appDbContext) : base(_appDbContext)
        {
            _devicePropertyValue = _appDbContext.Set<DevicePropertyValue>();
        }
        #endregion
    }
}
