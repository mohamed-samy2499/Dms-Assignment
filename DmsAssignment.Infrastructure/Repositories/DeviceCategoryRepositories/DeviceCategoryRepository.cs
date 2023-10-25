using Microsoft.EntityFrameworkCore;
using DmsAssignment.Domain.Entities;
using DmsAssignment.Infrastructure.Database;
using DmsAssignment.Infrastructure.Generic;

namespace DmsAssignment.Infrastructure.Repositories.DeviceCategoryRepositories
{
    public class CategoryRepository : GenericRepository<DeviceCategory>, IDeviceCategoryRepository
    {
        #region CTOR
        private DbSet<DeviceCategory> _deviceCategory;
        public CategoryRepository(AppDbContext _appDbContext) : base(_appDbContext)
        {
            _deviceCategory = _appDbContext.Set<DeviceCategory>();
        }
        #endregion

    }
}
