﻿// <auto-generated />
using System;
using DmsAssignment.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DmsAssignment.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231027085812_DevicePropertyVAlueMigration")]
    partial class DevicePropertyVAlueMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DmsAssignment.Domain.Entities.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AcquisitionDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeviceCategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Memo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeviceCategoryId");

                    b.ToTable("Device");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AcquisitionDate = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7740),
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7741),
                            DeviceCategoryId = 2,
                            IsDeleted = false,
                            Memo = "",
                            Name = "HP Desktop 1190",
                            SerialNo = "334cdh32-1"
                        });
                });

            modelBuilder.Entity("DmsAssignment.Domain.Entities.DeviceCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeviceCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7430),
                            IsDeleted = false,
                            Name = "Printer"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7491),
                            IsDeleted = false,
                            Name = "Laptop"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7496),
                            IsDeleted = false,
                            Name = "Switch"
                        });
                });

            modelBuilder.Entity("DmsAssignment.Domain.Entities.DeviceCategoryProperty", b =>
                {
                    b.Property<int>("DeviceCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("DeviceCategoryId", "PropertyId");

                    b.HasIndex("PropertyId");

                    b.HasIndex("DeviceCategoryId", "PropertyId")
                        .IsUnique();

                    b.ToTable("DeviceCategoryProperty");

                    b.HasData(
                        new
                        {
                            DeviceCategoryId = 1,
                            PropertyId = 5,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7577),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            DeviceCategoryId = 1,
                            PropertyId = 11,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7582),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            DeviceCategoryId = 1,
                            PropertyId = 12,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7678),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            DeviceCategoryId = 2,
                            PropertyId = 5,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7684),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            DeviceCategoryId = 2,
                            PropertyId = 1,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7687),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            DeviceCategoryId = 2,
                            PropertyId = 2,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7692),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            DeviceCategoryId = 2,
                            PropertyId = 12,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7695),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            DeviceCategoryId = 2,
                            PropertyId = 7,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7697),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            DeviceCategoryId = 2,
                            PropertyId = 13,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7700),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            DeviceCategoryId = 2,
                            PropertyId = 14,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7705),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            DeviceCategoryId = 3,
                            PropertyId = 5,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7709),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            DeviceCategoryId = 3,
                            PropertyId = 12,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7712),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            DeviceCategoryId = 3,
                            PropertyId = 8,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7716),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            DeviceCategoryId = 3,
                            PropertyId = 10,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7719),
                            Id = 0,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("DmsAssignment.Domain.Entities.DevicePropertyValue", b =>
                {
                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeviceId", "PropertyId");

                    b.HasIndex("PropertyId");

                    b.HasIndex("DeviceId", "PropertyId")
                        .IsUnique();

                    b.ToTable("DevicePropertyValue");

                    b.HasData(
                        new
                        {
                            DeviceId = 1,
                            PropertyId = 2,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7761),
                            Id = 1,
                            IsDeleted = false,
                            Value = "Core I7"
                        },
                        new
                        {
                            DeviceId = 1,
                            PropertyId = 5,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7769),
                            Id = 2,
                            IsDeleted = false,
                            Value = "192.168.1.5"
                        },
                        new
                        {
                            DeviceId = 1,
                            PropertyId = 7,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7772),
                            Id = 3,
                            IsDeleted = false,
                            Value = "Mohamed Samy"
                        });
                });

            modelBuilder.Entity("DmsAssignment.Domain.Entities.Extend.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("DmsAssignment.Domain.Entities.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Property");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7512),
                            IsDeleted = false,
                            Name = "HD"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7520),
                            IsDeleted = false,
                            Name = "Processor"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7523),
                            IsDeleted = false,
                            Name = "Dimensions"
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7526),
                            IsDeleted = false,
                            Name = "MAC Address"
                        },
                        new
                        {
                            Id = 5,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7530),
                            IsDeleted = false,
                            Name = "IP Address"
                        },
                        new
                        {
                            Id = 6,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7535),
                            IsDeleted = false,
                            Name = "Allow USB"
                        },
                        new
                        {
                            Id = 7,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7538),
                            IsDeleted = false,
                            Name = "Current User"
                        },
                        new
                        {
                            Id = 8,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7542),
                            IsDeleted = false,
                            Name = "Network Speed"
                        },
                        new
                        {
                            Id = 9,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7545),
                            IsDeleted = false,
                            Name = "Operating System"
                        },
                        new
                        {
                            Id = 10,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7549),
                            IsDeleted = false,
                            Name = "ports"
                        },
                        new
                        {
                            Id = 11,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7552),
                            IsDeleted = false,
                            Name = "Is Color"
                        },
                        new
                        {
                            Id = 12,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7555),
                            IsDeleted = false,
                            Name = "Brand"
                        },
                        new
                        {
                            Id = 13,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7558),
                            IsDeleted = false,
                            Name = "Display"
                        },
                        new
                        {
                            Id = 14,
                            DateCreated = new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7561),
                            IsDeleted = false,
                            Name = "Ram"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DmsAssignment.Domain.Entities.Device", b =>
                {
                    b.HasOne("DmsAssignment.Domain.Entities.DeviceCategory", "DeviceCategory")
                        .WithMany("Devices")
                        .HasForeignKey("DeviceCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeviceCategory");
                });

            modelBuilder.Entity("DmsAssignment.Domain.Entities.DeviceCategoryProperty", b =>
                {
                    b.HasOne("DmsAssignment.Domain.Entities.DeviceCategory", "DeviceCategory")
                        .WithMany("DeviceCategoryProperties")
                        .HasForeignKey("DeviceCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DmsAssignment.Domain.Entities.Property", "Property")
                        .WithMany("DeviceCategoryProperties")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeviceCategory");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("DmsAssignment.Domain.Entities.DevicePropertyValue", b =>
                {
                    b.HasOne("DmsAssignment.Domain.Entities.Device", "Device")
                        .WithMany("DevicePropertyValues")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DmsAssignment.Domain.Entities.Property", "Property")
                        .WithMany("DevicePropertyValues")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DmsAssignment.Domain.Entities.Extend.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DmsAssignment.Domain.Entities.Extend.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DmsAssignment.Domain.Entities.Extend.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DmsAssignment.Domain.Entities.Extend.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DmsAssignment.Domain.Entities.Device", b =>
                {
                    b.Navigation("DevicePropertyValues");
                });

            modelBuilder.Entity("DmsAssignment.Domain.Entities.DeviceCategory", b =>
                {
                    b.Navigation("DeviceCategoryProperties");

                    b.Navigation("Devices");
                });

            modelBuilder.Entity("DmsAssignment.Domain.Entities.Property", b =>
                {
                    b.Navigation("DeviceCategoryProperties");

                    b.Navigation("DevicePropertyValues");
                });
#pragma warning restore 612, 618
        }
    }
}
