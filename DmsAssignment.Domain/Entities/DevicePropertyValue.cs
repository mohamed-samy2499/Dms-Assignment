using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmsAssignment.Domain.Entities
{
    [Table("DevicePropertyValue")]
    public class DevicePropertyValue: BaseEntity
    {
        public string Value { get; set; } = null!;

        /*----- Relations -----*/

        public int DeviceId { get; set; }
        public int PropertyId { get; set; }
        public Device? Device { get; set; }
        public Property? Property { get; set; }
    }
}
