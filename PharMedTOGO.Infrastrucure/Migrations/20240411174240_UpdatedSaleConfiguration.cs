using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class UpdatedSaleConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea43725a-6ae9-4dd8-aa18-a9ce02779c87", "AQAAAAEAACcQAAAAENPfijPCQ1Bd/Ufy0Too/HmlD547D4kEoLRrDUBC7SEqE0UxQrA5/9lBUZ/NZigrmw==", "7a6c3606-bff7-43d0-93a1-73e45fb673ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e860e8c-ee38-4ca8-9004-2995555b5f98", "AQAAAAEAACcQAAAAENmDKdSpTUmEKHsXPBMtlU9njkzGZWXWLlkFsz+XIiRztVnSRBTCXG4sPsbOxz2Ocw==", "b6f3f7c0-c06b-427a-a103-c3e48fddffad" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 10, 9, 18, 1, 344, DateTimeKind.Utc).AddTicks(6821), new DateTime(2024, 4, 20, 12, 18, 1, 344, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 3, 30, 9, 18, 1, 344, DateTimeKind.Utc).AddTicks(6864), new DateTime(2024, 4, 10, 12, 18, 1, 344, DateTimeKind.Local).AddTicks(6864) });
        }
    }
}
