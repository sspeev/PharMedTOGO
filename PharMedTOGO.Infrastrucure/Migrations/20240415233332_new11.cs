using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class new11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsValid",
                table: "Prescriptions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "9aa3369b-c557-4b5f-96c2-540611829301");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e1b695f-d54b-4e7a-b7d9-b63241156a2a", "AQAAAAEAACcQAAAAEDRwdZh9XV6AMordDR4IBNeS2z705RyYd53sNKwPMj0hIE7sZrKVrVPs5L4EetRoyg==", "3e4f5f76-16f0-4c79-ad38-8196ebf73dc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3459476c-9d45-4413-8bb2-f7a8d4411411", "AQAAAAEAACcQAAAAEPA1yE+3sfHey8n8r4ZQNduWUX5HVNALVVt3m9IcN7RAUOEMjkioVDq8ncVYwji6Ow==", "4470a2a4-7324-4379-963b-121e6fb82e47" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 16, 2, 33, 32, 308, DateTimeKind.Local).AddTicks(5647), new DateTime(2024, 4, 26, 2, 33, 32, 308, DateTimeKind.Local).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 23, 33, 32, 308, DateTimeKind.Utc).AddTicks(5691), new DateTime(2024, 4, 16, 2, 33, 32, 308, DateTimeKind.Local).AddTicks(5691) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsValid",
                table: "Prescriptions");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "25f2eb5b-ea45-4306-b13a-bbca1cab72b3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8657180e-2384-4845-935f-de49873d8fd2", "AQAAAAEAACcQAAAAEDgHnpyPtcvs/dsLREILxKEXhB9+zxWZg5yrSxVpDWTgpj2Fsa6hh7bwwXE1bMPaPA==", "52b2de8b-39df-461c-bc4f-0d7148628ee4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8bc9e66-5e1e-4213-b17b-32f37b04d39b", "AQAAAAEAACcQAAAAEAqhmUnCzr0quulh4FGfZYgNztZHBEP61gbEv944/qQk90GeZ1O6YLs+fJ0zOqHCZA==", "73a03edf-48f4-4d84-8de7-eabd65aebf5a" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 16, 2, 26, 15, 737, DateTimeKind.Local).AddTicks(7895), new DateTime(2024, 4, 26, 2, 26, 15, 737, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 23, 26, 15, 737, DateTimeKind.Utc).AddTicks(7938), new DateTime(2024, 4, 16, 2, 26, 15, 737, DateTimeKind.Local).AddTicks(7939) });
        }
    }
}
