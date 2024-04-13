using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class RemovedProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApplied",
                table: "Sales",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is the sale applied on a medicine");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e26103da-b646-476d-b5f4-dc5663a69837", "AQAAAAEAACcQAAAAEJrghtdnThsweCNBjNj4YSK0bKsBhIJny9/nfzSjmoOWOWlPrSBz9sAgmJrol+EohQ==", "7af5fcbe-02a9-4504-bfe0-a931bda0269c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fed105a-9327-4541-830f-cad72e6e5e2f", "AQAAAAEAACcQAAAAEMA+eB+KguEcv6accMcs0KtZ6D7ldZ7CfbA3qogbbNEAqtBopGB+WZdC+EKi3U95Lw==", "71fcdfe6-f1e1-44d5-ae27-0ca3f9950878" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 42, 39, 768, DateTimeKind.Utc).AddTicks(9936), new DateTime(2024, 4, 21, 20, 42, 39, 768, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 42, 39, 768, DateTimeKind.Utc).AddTicks(9978), new DateTime(2024, 4, 11, 20, 42, 39, 768, DateTimeKind.Local).AddTicks(9979) });
        }
    }
}
