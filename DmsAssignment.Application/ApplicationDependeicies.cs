using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using DmsAssignment.Application.Behaviors;
using DmsAssignment.Application.IServices;
using DmsAssignment.Application.Services;
using System.Reflection;

namespace DmsAssignment.Application
{
    public static class ApplicationDependeicies
    {
        public static IServiceCollection AddApplicationDependeicies(this IServiceCollection services)
        {
            services.AddTransient<IDeviceService, DeviceService>();
            services.AddTransient<IDeviceCategoryService, DeviceCategoryService>();

            services.AddTransient<IDeviceCategoryPropertyService, DeviceCategoryPropertyService>();
            services.AddTransient<IDevicePropertyValueService, DevicePropertyValueService>();
            services.AddTransient<IPropertyService, PropertyService>();
            services.AddTransient<IPropertyTypeService, PropertyTypeService>();


            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            services.AddAutoMapper(Assembly.GetExecutingAssembly());


            // Get Validators
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            // 
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            return services;
        }
    }
}
