using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class addedNewEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MedicineId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => new { x.PatientId, x.MedicineId });
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "81134bf0-5d73-4d91-b18f-fe3abc9eae02");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a34f1ee-b065-4370-a56a-48f407ff325f", "AQAAAAEAACcQAAAAECGZi69ez6+vus0nFBodPYUaTIm0lwYhBZe/sE3/UzbUXQK2a+c9AWlFWD2BFvAMEg==", "3fbd0c3b-ee73-4f9f-b721-001083a9d19b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d37e04ea-0e16-4793-8096-9e8f07999a7d", "AQAAAAEAACcQAAAAEFAiI3hJxwZcj6idRvBB119lh12KjagkplwVGIAIG/5n/BdhOT4cRnqTXnThv85OzQ==", "a17b452b-844e-4eb2-9887-7accdd9d8d16" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 15, 53, 329, DateTimeKind.Local).AddTicks(3367), new DateTime(2024, 4, 26, 14, 15, 53, 329, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 5, 11, 15, 53, 329, DateTimeKind.Utc).AddTicks(3410), new DateTime(2024, 4, 16, 14, 15, 53, 329, DateTimeKind.Local).AddTicks(3411) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

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
    }
}
