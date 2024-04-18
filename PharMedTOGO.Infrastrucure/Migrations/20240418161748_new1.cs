using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class new1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "07af76a2-6452-426b-9958-475dd64dc6da");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PrescriptionId", "SecurityStamp" },
                values: new object[] { "4ec44b7a-5325-41da-adad-13378d5a4294", "AQAAAAEAACcQAAAAEBJHaCZ/Kt56OAhHw96KA8wcrxCHFQcRK6rBY0K3aQCMB+k3SYqtKKOuOrOiwPvJsg==", 2, "14a77a40-0bac-49c8-b30e-4ba030973efa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PrescriptionId", "SecurityStamp" },
                values: new object[] { "4390100c-716d-45c7-b38c-0f386ae0ec86", "AQAAAAEAACcQAAAAEB6VGoPMpwt6AOMTy45SVKm+1no6SecVMiVG5BU/z8cDzvU+P+qJDc5EFn78Ylxk5A==", 1, "2ae78a5a-8583-48eb-bcdf-4537529de981" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate", "PatientId" },
                values: new object[] { new DateTime(2024, 4, 18, 19, 17, 48, 138, DateTimeKind.Local).AddTicks(9101), new DateTime(2024, 4, 28, 19, 17, 48, 138, DateTimeKind.Local).AddTicks(9102), "" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate", "PatientId" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 17, 48, 138, DateTimeKind.Utc).AddTicks(9248), new DateTime(2024, 4, 18, 19, 17, 48, 138, DateTimeKind.Local).AddTicks(9248), "" });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "3d81e3ff-6800-4532-9528-a3cd178c1d00");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PrescriptionId", "SecurityStamp" },
                values: new object[] { "ba4da2e2-ade6-4bd8-a77c-d9be3a1fd4bf", "AQAAAAEAACcQAAAAED+ZkLEb81GvP7pHaE9fisiIvUP8X80i908gtDbljlG82j3NCnJfecAfmtqrMEiK6g==", null, "fbb1a3c6-b554-47f4-b0b5-e47fec4c1e94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PrescriptionId", "SecurityStamp" },
                values: new object[] { "6d5c4c86-80d1-42ea-b8d6-6853a4339c16", "AQAAAAEAACcQAAAAEJI1AOJ3wyANysgDVLhgtnapsr5cQ5YkSZqVPf8yoV2tVcoSWPkzaOONSirCmH+BTg==", null, "199f6900-2443-4298-9be8-5268475ac1a5" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate", "PatientId" },
                values: new object[] { new DateTime(2024, 4, 17, 23, 53, 47, 410, DateTimeKind.Local).AddTicks(8297), new DateTime(2024, 4, 27, 23, 53, 47, 410, DateTimeKind.Local).AddTicks(8336), "d42ae752-35a7-4ba3-a9c0-190484b6c253" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate", "PatientId" },
                values: new object[] { new DateTime(2024, 4, 6, 20, 53, 47, 410, DateTimeKind.Utc).AddTicks(8343), new DateTime(2024, 4, 17, 23, 53, 47, 410, DateTimeKind.Local).AddTicks(8343), "3fe16750-157b-4110-a05f-0d2ba0812b3c" });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
