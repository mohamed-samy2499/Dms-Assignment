using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmsAssignment.Application.Feature.Devices.Commands.Models
{
    public class DevicePropertyCommand
    {
        public int PropertyId { get; set; }
        public string? Value { get; set; }
    }
}
