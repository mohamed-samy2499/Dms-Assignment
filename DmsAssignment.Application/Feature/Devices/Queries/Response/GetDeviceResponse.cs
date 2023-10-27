﻿namespace DmsAssignment.Application.Feature.Devices.Queries.Response
{
    public class GetDeviceResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string SerialNo { get; set; } = null!;

        public DateTime AcquisitionDate { get; set; }
        public string Memo { get; set; } = null!;


        // ---------- relations -----------
        public string DeviceCategoryName { get; set; } = null!;
        public Dictionary<string, string> PropertiesWithValues { get; set; } = null!;
        public List<int> PropertiesIds { get; set; }
    }
}
