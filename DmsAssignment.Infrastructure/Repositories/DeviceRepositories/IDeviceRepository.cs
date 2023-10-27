using DmsAssignment.Domain.Entities;
using DmsAssignment.Infrastructure.Generic;


namespace DmsAssignment.Infrastructure.Repositories.DeviceRepositories
{
    public interface IDeviceRepository : IGenericRepository<Device>
    {
        Task<Device> GetDeviceRelationsById(int Id);
    }
}
