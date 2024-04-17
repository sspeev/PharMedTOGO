using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class changedSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ba4da2e2-ade6-4bd8-a77c-d9be3a1fd4bf", "test@mail.com", "Test", "Testov", "TEST@MAIL.COM", "TEST@MAIL.COM", "AQAAAAEAACcQAAAAED+ZkLEb81GvP7pHaE9fisiIvUP8X80i908gtDbljlG82j3NCnJfecAfmtqrMEiK6g==", "fbb1a3c6-b554-47f4-b0b5-e47fec4c1e94", "test@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6d5c4c86-80d1-42ea-b8d6-6853a4339c16", "admin@mail.com", "Admin", "Adminov", "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEJI1AOJ3wyANysgDVLhgtnapsr5cQ5YkSZqVPf8yoV2tVcoSWPkzaOONSirCmH+BTg==", "199f6900-2443-4298-9be8-5268475ac1a5", "admin@mail.com" });

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
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 6, 20, 53, 47, 410, DateTimeKind.Utc).AddTicks(8343), new DateTime(2024, 4, 17, 23, 53, 47, 410, DateTimeKind.Local).AddTicks(8343) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "7d34517d-eb62-4e18-94ce-a863ab7d2921");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "26ad3643-9426-4a0b-a1c8-49162f749d40", "kristalin@mail.com", "Kristalin", "Zhelezhchev", "KRISTALIN@MAIL.COM", "KRISTALIN@MAIL.COM", "AQAAAAEAACcQAAAAEE2LlLqgZ703fxxksz6uO/sGjDCXiBTFdzWwpHSUuCli5jElGn1TeStVANomGorAuQ==", "b245619d-312a-4ff6-9356-8c8a0097ff7f", "kristalin@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3b7c3b92-3659-4ebd-9ccd-dfd1bd515b66", "stoyan@mail.com", "Stoyan", "Peev", "STOYAN@MAIL.COM", "STOYAN@MAIL.COM", "AQAAAAEAACcQAAAAEHEZZ86j6DwzRvpb+5w6CRHIkyyTnhGFVlgEMXnr5y6WXQXDSJS/nPuVq9VltP7EfA==", "29113b7f-268b-48bc-805f-6e0d772ca431", "stoyan@mail.com" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate", "PatientId" },
                values: new object[] { new DateTime(2024, 4, 17, 14, 11, 4, 8, DateTimeKind.Local).AddTicks(1048), new DateTime(2024, 4, 27, 14, 11, 4, 8, DateTimeKind.Local).AddTicks(1092), "f13628c2-5ff0-4d1c-a0e2-2527ec425aa4" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 11, 4, 8, DateTimeKind.Utc).AddTicks(1098), new DateTime(2024, 4, 17, 14, 11, 4, 8, DateTimeKind.Local).AddTicks(1098) });
        }
    }
}
