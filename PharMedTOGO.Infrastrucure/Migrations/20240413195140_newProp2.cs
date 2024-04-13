using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class newProp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApplied",
                table: "Sales");

            migrationBuilder.AddColumn<bool>(
                name: "HasSaleApplied",
                table: "Medicines",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is the sale applied");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6db6099-54a1-424c-9b6d-f78bf1fc46df", "AQAAAAEAACcQAAAAEIyny883VZrNNCJ9jk/g7hlaUMzBTjaxvqgE8xzuauu9UJhribDXxijKXACiL8yjIQ==", "b67085d0-5c78-4581-83db-e3b9f3a3f51e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb0b7481-5ccb-473f-8f15-bfa6671731ea", "AQAAAAEAACcQAAAAEKg8pGY+V6irw1X/ZgzfoEQ/aXB5OF9vVWY339eNl5/fP6iUkiEdK99jP+E6cO4NMw==", "d43982ab-14d7-47b9-b5af-780a74d06187" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 13, 19, 51, 39, 903, DateTimeKind.Utc).AddTicks(9946), new DateTime(2024, 4, 23, 22, 51, 39, 903, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 2, 19, 51, 39, 903, DateTimeKind.Utc).AddTicks(9991), new DateTime(2024, 4, 13, 22, 51, 39, 903, DateTimeKind.Local).AddTicks(9991) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasSaleApplied",
                table: "Medicines");

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
    }
}
