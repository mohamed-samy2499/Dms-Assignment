

using System.ComponentModel.DataAnnotations.Schema;

namespace DmsAssignment.Domain.Entities
{
    [Table("DeviceCategoryProperty")]
    public class DeviceCategoryProperty : BaseEntity
    {
        public int DeviceCategoryId { get; set; }
        public DeviceCategory? DeviceCategory { get; set; }

        public int PropertyId { get; set; }
        public Property? Property { get; set; }
    }
}
