
using System.ComponentModel.DataAnnotations.Schema;

namespace DmsAssignment.Domain.Entities
{
    [Table("PropertyType")]
    public class PropertyType : BaseEntity
    {
        public string Name { get; set; } = null!;

        /*----- Relations -----*/
        public int PropertyId { get; set; }
        public IEnumerable<Property> Property { get; set; } = null!;

    }
}

//this table to determine the type of the property if it's boolean or string 
//for example the IsColor property will have the type of boolean,, and the Ip will be string