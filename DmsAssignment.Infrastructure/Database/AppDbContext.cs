using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DmsAssignment.Domain.Entities;
using DmsAssignment.Domain.Entities.Extend;

namespace DmsAssignment.Infrastructure.Database
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        #region DbSets
        public DbSet<Device> Devices { get; set; } = null!;
        public DbSet<DeviceCategory> DeviceCategories { get; set; } = null!;
        public DbSet<DevicePropertyValue> DevicePropertyValues { get; set; } = null!;
        public DbSet<Property> Properties { get; set; } = null!;

        public DbSet<PropertyType> PropertyTypes { get; set; } = null!;
        public DbSet<DeviceCategoryProperty> DeviceCategoryProperties { get; set; } = null!;

        #endregion

        public AppDbContext() { }
        public AppDbContext(DbContextOptions options) : base(options) { }

        override protected void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region SoftDelete Query Filter
            //A query filter applied to any query to exclude the Soft Deleted Entities
            builder.Entity<Device>()
                .HasQueryFilter(x => !x.IsDeleted);

            builder.Entity<DeviceCategory>()
                .HasQueryFilter(x => !x.IsDeleted);

            builder.Entity<Property>()
                .HasQueryFilter(x => !x.IsDeleted);

            builder.Entity<PropertyType>()
                .HasQueryFilter(x => !x.IsDeleted);

            builder.Entity<DeviceCategoryProperty>()
                .HasQueryFilter(x => !x.IsDeleted);

            builder.Entity<DevicePropertyValue>()
                .HasQueryFilter(x => !x.IsDeleted);
            #endregion
            
            #region Data Seeding

            builder.Entity<DeviceCategory>(builder =>
            {
                builder.HasData(new DeviceCategory { Id = 1, Name = "Printer" });
                builder.HasData(new DeviceCategory { Id = 2, Name = "Laptop" });
                builder.HasData(new DeviceCategory { Id = 3, Name = "Switch" });

            });

            builder.Entity<PropertyType>(builder =>
            {
                builder.HasData(new PropertyType { Id = 1, Name = "String" });
                builder.HasData(new PropertyType { Id = 2, Name = "Boolean" });
            });

            builder.Entity<Property>(builder =>
            {
                builder.HasData(new Property { Id = 1, Name = "HD", PropertyTypeId = 1});
                builder.HasData(new Property { Id = 2, Name = "Processor", PropertyTypeId = 1 });
                builder.HasData(new Property { Id = 3, Name = "Dimensions", PropertyTypeId = 1 });
                builder.HasData(new Property { Id = 4, Name = "MAC Address", PropertyTypeId = 1 });
                builder.HasData(new Property { Id = 5, Name = "IP Address", PropertyTypeId = 1 });
                builder.HasData(new Property { Id = 6, Name = "Allow USB", PropertyTypeId = 2 });
                builder.HasData(new Property { Id = 7, Name = "Current User", PropertyTypeId = 1 });
                builder.HasData(new Property { Id = 8, Name = "Network Speed", PropertyTypeId = 1 });
                builder.HasData(new Property { Id = 9, Name = "Operating System", PropertyTypeId = 1 });
                builder.HasData(new Property { Id = 10, Name = "ports", PropertyTypeId = 1 });
                builder.HasData(new Property { Id = 11, Name = "Is Color", PropertyTypeId = 2 });
                builder.HasData(new Property { Id = 12, Name = "Brand", PropertyTypeId = 1 });
                builder.HasData(new Property { Id = 13, Name = "Display", PropertyTypeId = 1 });
                builder.HasData(new Property { Id = 14, Name = "Ram", PropertyTypeId = 1 });


            });
            //link the DeviceCategories and the Properties
            builder.Entity<DeviceCategoryProperty>(builder =>
            {
                builder.HasData(new DeviceCategoryProperty { DeviceCategoryId = 1, PropertyId = 5 });
                builder.HasData(new DeviceCategoryProperty { DeviceCategoryId = 1, PropertyId = 11 });
                builder.HasData(new DeviceCategoryProperty { DeviceCategoryId = 1, PropertyId = 12 });


                builder.HasData(new DeviceCategoryProperty { DeviceCategoryId = 2, PropertyId = 5 });
                builder.HasData(new DeviceCategoryProperty { DeviceCategoryId = 2, PropertyId = 1 });
                builder.HasData(new DeviceCategoryProperty { DeviceCategoryId = 2, PropertyId = 2 });
                builder.HasData(new DeviceCategoryProperty { DeviceCategoryId = 2, PropertyId = 12 });
                builder.HasData(new DeviceCategoryProperty { DeviceCategoryId = 2, PropertyId = 7 });
                builder.HasData(new DeviceCategoryProperty { DeviceCategoryId = 2, PropertyId = 13 });
                builder.HasData(new DeviceCategoryProperty { DeviceCategoryId = 2, PropertyId = 14 });


                builder.HasData(new DeviceCategoryProperty { DeviceCategoryId = 3, PropertyId = 5 });
                builder.HasData(new DeviceCategoryProperty { DeviceCategoryId = 3, PropertyId = 12 });
                builder.HasData(new DeviceCategoryProperty { DeviceCategoryId = 3, PropertyId = 8 });
                builder.HasData(new DeviceCategoryProperty { DeviceCategoryId = 3, PropertyId = 10 });


            });

            builder.Entity<Device>(builder =>
            {
                builder.HasData(new Device { Id = 1, Name = "HP Desktop 1190", 
                    SerialNo = "334cdh32-1", Memo = "" , DeviceCategoryId = 2});
            });

            builder.Entity<DevicePropertyValue>(builder =>
            {
                builder.HasData(new DevicePropertyValue { Id = 1, DeviceId = 1, PropertyId = 2, Value = "Core I7"});
                builder.HasData(new DevicePropertyValue { Id = 2, DeviceId = 1, PropertyId = 5, Value = "192.168.1.5" });
                builder.HasData(new DevicePropertyValue { Id = 3, DeviceId = 1, PropertyId = 7, Value = "Mohamed Samy" });


            });
            #endregion

            #region Db Relations
            //DeviceCategoryProperty Table the Many to Many relation
            //between the DeviceCategory and the Property tables
            builder.Entity<DeviceCategoryProperty>(builder =>
            {
                builder
                .HasKey(r => new { r.DeviceCategoryId, r.PropertyId });

                builder
               .HasIndex(r => new { r.DeviceCategoryId, r.PropertyId })
               .IsUnique();

                builder
                .HasOne(r => r.DeviceCategory)
                .WithMany(u => u.DeviceCategoryProperties)
                .HasForeignKey(r => r.DeviceCategoryId);

                builder
                .HasOne(r => r.Property)
                .WithMany(u => u.DeviceCategoryProperties)
                .HasForeignKey(r => r.PropertyId);
            });

            //DevicePropertyValue Table the Many to Many relation
            //between the Device and the Property tables
            builder.Entity<DevicePropertyValue>(builder =>
            {
                builder
                .HasKey(r => new { r.DeviceId, r.PropertyId });

                builder
               .HasIndex(r => new { r.DeviceId, r.PropertyId })
               .IsUnique();

                builder
                .HasOne(r => r.Device)
                .WithMany(u => u.DevicePropertyValues)
                .HasForeignKey(r => r.DeviceId);

                builder
                .HasOne(r => r.Property)
                .WithMany(u => u.DevicePropertyValues)
                .HasForeignKey(r => r.PropertyId);
            });
            #endregion
        }
    }
}




