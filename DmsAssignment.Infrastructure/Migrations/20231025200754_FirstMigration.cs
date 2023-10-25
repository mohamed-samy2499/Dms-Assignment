using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DmsAssignment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcquisitionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Memo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceCategoryId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Device_DeviceCategory_DeviceCategoryId",
                        column: x => x.DeviceCategoryId,
                        principalTable: "DeviceCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyTypeId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Property_PropertyType_PropertyTypeId",
                        column: x => x.PropertyTypeId,
                        principalTable: "PropertyType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCategoryProperty",
                columns: table => new
                {
                    DeviceCategoryId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCategoryProperty", x => new { x.DeviceCategoryId, x.PropertyId });
                    table.ForeignKey(
                        name: "FK_DeviceCategoryProperty_DeviceCategory_DeviceCategoryId",
                        column: x => x.DeviceCategoryId,
                        principalTable: "DeviceCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeviceCategoryProperty_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DevicePropertyValue",
                columns: table => new
                {
                    DeviceId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevicePropertyValue", x => new { x.DeviceId, x.PropertyId });
                    table.ForeignKey(
                        name: "FK_DevicePropertyValue_Device_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Device",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DevicePropertyValue_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DeviceCategory",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3486), null, null, false, "Printer" },
                    { 2, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3540), null, null, false, "Laptop" },
                    { 3, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3544), null, null, false, "Switch" }
                });

            migrationBuilder.InsertData(
                table: "PropertyType",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "PropertyId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3561), null, null, false, "String", 0 },
                    { 2, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3568), null, null, false, "Boolean", 0 }
                });

            migrationBuilder.InsertData(
                table: "Device",
                columns: new[] { "Id", "AcquisitionDate", "DateCreated", "DateDeleted", "DateUpdated", "DeviceCategoryId", "IsDeleted", "Memo", "Name", "SerialNo" },
                values: new object[] { 1, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3759), new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3761), null, null, 2, false, "", "HP Desktop 1190", "334cdh32-1" });

            migrationBuilder.InsertData(
                table: "Property",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "PropertyTypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3587), null, null, false, "HD", 1 },
                    { 2, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3594), null, null, false, "Processor", 1 },
                    { 3, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3597), null, null, false, "Dimensions", 1 },
                    { 4, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3601), null, null, false, "MAC Address", 1 },
                    { 5, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3604), null, null, false, "IP Address", 1 },
                    { 6, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3609), null, null, false, "Allow USB", 2 },
                    { 7, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3612), null, null, false, "Current User", 1 },
                    { 8, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3615), null, null, false, "Network Speed", 1 },
                    { 9, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3619), null, null, false, "Operating System", 1 },
                    { 10, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3667), null, null, false, "ports", 1 },
                    { 11, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3671), null, null, false, "Is Color", 2 },
                    { 12, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3674), null, null, false, "Brand", 1 },
                    { 13, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3677), null, null, false, "Display", 1 },
                    { 14, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3680), null, null, false, "Ram", 1 }
                });

            migrationBuilder.InsertData(
                table: "DeviceCategoryProperty",
                columns: new[] { "DeviceCategoryId", "PropertyId", "DateCreated", "DateDeleted", "DateUpdated", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3699), null, null, 0, false },
                    { 1, 11, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3706), null, null, 0, false },
                    { 1, 12, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3709), null, null, 0, false },
                    { 2, 1, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3715), null, null, 0, false },
                    { 2, 2, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3719), null, null, 0, false },
                    { 2, 5, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3712), null, null, 0, false },
                    { 2, 7, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3725), null, null, 0, false },
                    { 2, 12, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3722), null, null, 0, false },
                    { 2, 13, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3728), null, null, 0, false },
                    { 2, 14, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3732), null, null, 0, false },
                    { 3, 5, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3735), null, null, 0, false },
                    { 3, 8, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3741), null, null, 0, false },
                    { 3, 10, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3744), null, null, 0, false },
                    { 3, 12, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3738), null, null, 0, false }
                });

            migrationBuilder.InsertData(
                table: "DevicePropertyValue",
                columns: new[] { "DeviceId", "PropertyId", "DateCreated", "DateDeleted", "DateUpdated", "Id", "IsDeleted", "Value" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3777), null, null, 1, false, "Core I7" },
                    { 1, 5, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3783), null, null, 2, false, "192.168.1.5" },
                    { 1, 7, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3786), null, null, 3, false, "Mohamed Samy" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Device_DeviceCategoryId",
                table: "Device",
                column: "DeviceCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCategoryProperty_DeviceCategoryId_PropertyId",
                table: "DeviceCategoryProperty",
                columns: new[] { "DeviceCategoryId", "PropertyId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCategoryProperty_PropertyId",
                table: "DeviceCategoryProperty",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_DevicePropertyValue_DeviceId_PropertyId",
                table: "DevicePropertyValue",
                columns: new[] { "DeviceId", "PropertyId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DevicePropertyValue_PropertyId",
                table: "DevicePropertyValue",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_PropertyTypeId",
                table: "Property",
                column: "PropertyTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DeviceCategoryProperty");

            migrationBuilder.DropTable(
                name: "DevicePropertyValue");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Device");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "DeviceCategory");

            migrationBuilder.DropTable(
                name: "PropertyType");
        }
    }
}
