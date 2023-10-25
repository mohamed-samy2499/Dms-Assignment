﻿
using System.ComponentModel.DataAnnotations.Schema;

namespace DmsAssignment.Domain.Entities
{
    [Table("Property")]
    public class Property: BaseEntity
    {
        public string Name { get; set; } = null!;

        /*----- Relations -----*/
        public int PropertyTypeId { get; set; }

        public PropertyType? PropertyType { get; set; }

        public IEnumerable<DeviceCategoryProperty> DeviceCategoryProperties { get; set; } = null!;

        public IEnumerable<DevicePropertyValue> DevicePropertyValues { get; set; } = null!;

    }
}
