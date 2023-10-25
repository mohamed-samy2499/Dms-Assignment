

using System.ComponentModel.DataAnnotations.Schema;

namespace DmsAssignment.Domain.Entities
{
    [Table("DeviceCategory")]
    public class DeviceCategory: BaseEntity
    {
        public string Name { get; set; } = null!;

        /*----- Relations -----*/
        public IEnumerable<Property> Properties { get; set; } = null!;
    }
}
