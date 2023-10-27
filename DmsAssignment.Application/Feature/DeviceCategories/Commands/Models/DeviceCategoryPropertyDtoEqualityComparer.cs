using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmsAssignment.Application.Feature.DeviceCategories.Commands.Models
{
    public class DeviceCategoryPropertyDtoEqualityComparer : IEqualityComparer<DeviceCategoryPropertyDto>
    {
        public bool Equals(DeviceCategoryPropertyDto x, DeviceCategoryPropertyDto y)
        {
            // Compare the properties of the objects to determine equality
            return x.PropertyId == y.PropertyId
                && x.PropertyName == y.PropertyName
                && x.IsSelected == y.IsSelected;
        }

        public int GetHashCode(DeviceCategoryPropertyDto obj)
        {
            // Create a hash code based on the properties
            return obj.PropertyId.GetHashCode() ^ obj.PropertyName.GetHashCode() ^ obj.IsSelected.GetHashCode();
        }
    }
}
