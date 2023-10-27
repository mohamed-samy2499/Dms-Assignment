using AutoMapper;
using DmsAssignment.Domain.Entities;
namespace DmsAssignment.Application.Mapping.Devices
{
    public class DevicePropertyValueValueConverter : IValueConverter<Dictionary<string, string>, IEnumerable<DevicePropertyValue>>
    {
        public IEnumerable<DevicePropertyValue> Convert(Dictionary<string, string> source, ResolutionContext context)
        {
            var devicePropertyValues = new List<DevicePropertyValue>();

            foreach (var (key, value) in source)
            {
                var devicePropertyValue = new DevicePropertyValue();

                devicePropertyValue.Value = value;

                devicePropertyValues.Add(devicePropertyValue);
            }

            return devicePropertyValues;
        }
    }
}
