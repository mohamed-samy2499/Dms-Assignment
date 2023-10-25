
using System.ComponentModel.DataAnnotations.Schema;

namespace DmsAssignment.Domain.Entities
{
    [Table("Property")]
    public class Property: BaseEntity
    {
        public string Name { get; set; } = null!;

        /*----- Relations -----*/
        public int DeviceCategoryId { get; set; }
        public int DevicePropertyValueId { get; set; }

        public DeviceCategory? DeviceCategory { get; set; }

        public IEnumerable<DevicePropertyValue> DevicePropertyValue { get; set; } = null!;

    }
}
