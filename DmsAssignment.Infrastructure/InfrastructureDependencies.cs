using Microsoft.Extensions.DependencyInjection;
using DmsAssignment.Infrastructure.Generic;
using DmsAssignment.Infrastructure.Repositories.DeviceRepositories;
using DmsAssignment.Infrastructure.Repositories.DeviceCategoryRepositories;
using DmsAssignment.Infrastructure.Repositories.DeviceCategoryPropertyRepositories;
using DmsAssignment.Infrastructure.Repositories.DevicePropertyValueRepositories;
using DmsAssignment.Infrastructure.Repositories.PropertyRepositories;

namespace DmsAssignment.Infrastructure
{
    public static class InfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddTransient<IDeviceRepository, DeviceRepository>();
            services.AddTransient<IDeviceCategoryRepository, DeviceCategoryRepository>();
            services.AddTransient<IDeviceCategoryPropertyRepository, DeviceCategoryPropertyRepository>();
            services.AddTransient<IDevicePropertyValueRepository, DevicePropertyValueRepository>();
            services.AddTransient<IPropertyRepository, PropertyRepository>();

            return services;
        }
    }
}
