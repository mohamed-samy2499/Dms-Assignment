using Microsoft.EntityFrameworkCore;
using DmsAssignment.Domain.Entities;
using DmsAssignment.Infrastructure.Database;
using DmsAssignment.Infrastructure.Generic;

namespace DmsAssignment.Infrastructure.Repositories.PropertyRepositories
{
    public class PropertyRepository : GenericRepository<Property>, IPropertyRepository
    {
        #region CTOR
        private DbSet<Property> _property;
        public PropertyRepository(AppDbContext _appDbContext) : base(_appDbContext)
        {
            _property = _appDbContext.Set<Property>();
        }
        #endregion
    }
}
