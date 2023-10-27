using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DmsAssignment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DevicePropertyVAlueMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Device",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcquisitionDate", "DateCreated" },
                values: new object[] { new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7740), new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "DeviceCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "DeviceCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "DeviceCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 1, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 1, 11 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 1, 12 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 1 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 7 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 12 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 13 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 2, 14 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 3, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 3, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 3, 10 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "DeviceCategoryProperty",
                keyColumns: new[] { "DeviceCategoryId", "PropertyId" },
                keyValues: new object[] { 3, 12 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "DevicePropertyValue",
                keyColumns: new[] { "DeviceId", "PropertyId" },
                keyValues: new object[] { 1, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "DevicePropertyValue",
                keyColumns: new[] { "DeviceId", "PropertyId" },
                keyValues: new object[] { 1, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "DevicePropertyValue",
                keyColumns: new[] { "DeviceId", "PropertyId" },
                keyValues: new object[] { 1, 7 },
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2023, 10, 27, 10, 58, 12, 81, DateTimeKind.Local).AddTicks(7561));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
