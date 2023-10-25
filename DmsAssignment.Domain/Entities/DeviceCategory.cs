

using System.ComponentModel.DataAnnotations.Schema;

namespace DmsAssignment.Domain.Entities
{
    [Table("DeviceCategory")]
    public class DeviceCategory: BaseEntity
    {
        public string Name { get; set; } = null!;

        /*----- Relations -----*/
        public IEnumerable<DeviceCategoryProperty> DeviceCategoryProperties { get; set; } = null!;
        public IEnumerable<Device> Devices { get; set; } = null!;

    }
}
