
using System.ComponentModel.DataAnnotations.Schema;


namespace DmsAssignment.Domain.Entities
{
    [Table("Device")]
    public class Device : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string SerialNo { get; set; } = null!;

        public DateTime AcquisitionDate { get; set; } = DateTime.Now;
        public string Memo { get; set; } = null!;

        /*----- Relations -----*/
        public int DeviceCategoryId { get; set; }

        public DeviceCategory? DeviceCategory { get; set; }

        public IEnumerable<DevicePropertyValue> DevicePropertyValues { get; set; } = null!;

    }
}
