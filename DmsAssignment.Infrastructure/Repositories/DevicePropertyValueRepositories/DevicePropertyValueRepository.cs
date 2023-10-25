using Microsoft.EntityFrameworkCore;
using DmsAssignment.Domain.Entities;
using DmsAssignment.Infrastructure.Database;
using DmsAssignment.Infrastructure.Generic;

namespace DmsAssignment.Infrastructure.Repositories.DevicePropertyValueRepositories
{
    public class CategoryRepository : GenericRepository<DevicePropertyValue>, IDevicePropertyValueRepository
    {
        #region CTOR
        private DbSet<DevicePropertyValue> _devicePropertyValue;
        public CategoryRepository(AppDbContext _appDbContext) : base(_appDbContext)
        {
            _devicePropertyValue = _appDbContext.Set<DevicePropertyValue>();
        }
        #endregion
    }
}
