using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DmsAssignment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PropertyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Property_PropertyType_PropertyTypeId",
                table: "Property");

            migrationBuilder.DropTable(
                name: "PropertyType");

            migrationBuilder.DropIndex(
                name: "IX_Property_PropertyTypeId",
                table: "Property");

            migrationBuilder.DropColumn(
                name: "PropertyTypeId",
                table: "Property");

            migrationBuilder.UpdateData(
                table: "Device",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcquisitionDate", "DateCreated" },
                values: new object[] { new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(7059), new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "DeviceCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "DeviceCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "DeviceCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 1, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 1, 11 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 1, 12 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 1 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 7 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 12 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 13 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 14 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 3, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 3, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 3, 10 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 3, 12 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "DevicePropertyValue",
                keyColumns: new[] { "DeviceId", "PropertyId" },
                keyValues: new object[] { 1, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "DevicePropertyValue",
                keyColumns: new[] { "DeviceId", "PropertyId" },
                keyValues: new object[] { 1, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "DevicePropertyValue",
                keyColumns: new[] { "DeviceId", "PropertyId" },
                keyValues: new object[] { 1, 7 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 7, 6, 35, 938, DateTimeKind.Local).AddTicks(6977));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PropertyTypeId",
                table: "Property",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PropertyType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyType", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Device",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcquisitionDate", "DateCreated" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3759), new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "DeviceCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "DeviceCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "DeviceCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 1, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 1, 11 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 1, 12 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 1 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 7 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 12 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 13 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 14 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 3, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 3, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 3, 10 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 3, 12 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "DevicePropertyValue",
                keyColumns: new[] { "DeviceId", "PropertyId" },
                keyValues: new object[] { 1, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "DevicePropertyValue",
                keyColumns: new[] { "DeviceId", "PropertyId" },
                keyValues: new object[] { 1, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "DevicePropertyValue",
                keyColumns: new[] { "DeviceId", "PropertyId" },
                keyValues: new object[] { 1, 7 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "PropertyTypeId" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3587), 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "PropertyTypeId" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3594), 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "PropertyTypeId" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3597), 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "PropertyTypeId" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3601), 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "PropertyTypeId" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3604), 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "PropertyTypeId" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3609), 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "PropertyTypeId" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3612), 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "PropertyTypeId" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3615), 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "PropertyTypeId" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3619), 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "PropertyTypeId" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3667), 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "PropertyTypeId" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3671), 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "PropertyTypeId" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3674), 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "PropertyTypeId" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3677), 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "PropertyTypeId" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3680), 1 });

            migrationBuilder.InsertData(
                table: "PropertyType",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "PropertyId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3561), null, null, false, "String", 0 },
                    { 2, new DateTime(2023, 10, 25, 23, 7, 54, 99, DateTimeKind.Local).AddTicks(3568), null, null, false, "Boolean", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Property_PropertyTypeId",
                table: "Property",
                column: "PropertyTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_PropertyType_PropertyTypeId",
                table: "Property",
                column: "PropertyTypeId",
                principalTable: "PropertyType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
