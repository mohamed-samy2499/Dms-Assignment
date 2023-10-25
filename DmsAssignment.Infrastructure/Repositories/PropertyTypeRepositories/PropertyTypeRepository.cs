using Microsoft.EntityFrameworkCore;
using DmsAssignment.Domain.Entities;
using DmsAssignment.Infrastructure.Database;
using DmsAssignment.Infrastructure.Generic;

namespace DmsAssignment.Infrastructure.Repositories.PropertyRepositories
{
    public class PropertyTypeRepository : GenericRepository<PropertyType>, IPropertyTypeRepository
    {
        #region CTOR
        private DbSet<PropertyType> _propertyType;
        public PropertyTypeRepository(AppDbContext _appDbContext) : base(_appDbContext)
        {
            _propertyType = _appDbContext.Set<PropertyType>();
        }
        #endregion
    }
}
