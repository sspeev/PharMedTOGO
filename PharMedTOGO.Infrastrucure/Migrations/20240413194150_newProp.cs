using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class newProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApplied",
                table: "Sales",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is the sale applied");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e0da4a2-b288-4c09-9110-d7ee844cd7ad", "AQAAAAEAACcQAAAAEKg0Pz8zLty0HIQaZKS29QlX/O4NEeSMA9WLvK2D1W4bMzuO5db0V/cnU62qkms7Rg==", "66b06ebe-77f9-4b29-89f8-fcd13818db8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89a20d69-11c8-4e6a-8044-5513275f2afe", "AQAAAAEAACcQAAAAEHrrWrSqXkJlyk5MZVpunvBSBYPEvP5gB+l3YaFfzBpcwZsmbD/XvnC0mH7hJbKUwg==", "21755960-1b84-4e2e-9cfc-bc9e6450e358" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 13, 19, 41, 50, 252, DateTimeKind.Utc).AddTicks(5003), new DateTime(2024, 4, 23, 22, 41, 50, 252, DateTimeKind.Local).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 2, 19, 41, 50, 252, DateTimeKind.Utc).AddTicks(5047), new DateTime(2024, 4, 13, 22, 41, 50, 252, DateTimeKind.Local).AddTicks(5048) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApplied",
                table: "Sales");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb6eb6f8-3d63-467a-baf0-832864d69e0e", "AQAAAAEAACcQAAAAEMfcVk86tcINEhgTBR1a64FR6sghaZg46PMEx9IQeNuKUF8Qc0S0r69nCx5onMlj7g==", "683494b2-2cfa-4975-96eb-36d69d74bad1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee0ef839-71f8-433c-abb0-989df9f4a16d", "AQAAAAEAACcQAAAAEDcnZEwjSKwkA0+7v55/mMvflOV4S4XIq+Gks4gqQ/fZXHg1bMqDogiXcYus1mY0Ow==", "20b40d19-2130-4ac9-be9b-70ce79f3291c" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 13, 17, 55, 26, 327, DateTimeKind.Utc).AddTicks(464), new DateTime(2024, 4, 23, 20, 55, 26, 327, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 2, 17, 55, 26, 327, DateTimeKind.Utc).AddTicks(509), new DateTime(2024, 4, 13, 20, 55, 26, 327, DateTimeKind.Local).AddTicks(510) });
        }
    }
}
