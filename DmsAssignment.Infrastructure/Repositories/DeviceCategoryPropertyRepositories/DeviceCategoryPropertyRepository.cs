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
        #endregion
    }
}
