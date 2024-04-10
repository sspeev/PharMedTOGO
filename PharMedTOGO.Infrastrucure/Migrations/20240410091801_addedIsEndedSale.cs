using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class addedIsEndedSale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEnded",
                table: "Sales",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is the sale ended");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEnded",
                table: "Sales");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0096962-8bbe-4bb6-8101-007974f7942c", "AQAAAAEAACcQAAAAEDC4f4Aw10l2gJk4uuGvbW3U5stUfqLSPo3OFAiK5Qm9yvV+7WSMMf13BPFrY4Q+1A==", "30d65287-a2a0-4389-a21f-3fe22c4e9259" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc79baeb-f894-42e9-b29f-3ff0da2b2f61", "AQAAAAEAACcQAAAAEFmUFn1/KzcZrEDbviSemSpXleDjmzZ0U08wCKmoNYwwV1ERNF2MNI9fduJzGfg6vg==", "d7f4fba4-82bd-466f-927c-3bf4905a9cc5" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 10, 9, 3, 14, 956, DateTimeKind.Utc).AddTicks(1312), new DateTime(2024, 4, 20, 12, 3, 14, 956, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 3, 30, 9, 3, 14, 956, DateTimeKind.Utc).AddTicks(1359), new DateTime(2024, 4, 10, 12, 3, 14, 956, DateTimeKind.Local).AddTicks(1360) });
        }
    }
}
