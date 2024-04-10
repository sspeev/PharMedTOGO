using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class addedIsAppliedSale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "c3c5e889-dfab-4547-bf35-a7b0c3124d87", "AQAAAAEAACcQAAAAEIZOGqljyXpFFqmJ5BNIwkyJFaahICk5KxOami8f16hk+GTX1mw6TiKpy6PLMBWwVQ==", "666153dd-ce45-4866-9c06-7705c7444c9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e94243c-a414-476b-982a-c23ded1201c5", "AQAAAAEAACcQAAAAEG+jns+fuIM1CGlu9y8wEouQK/muTKa4fxyeDS5/qyHF1/yIKcl8KDr7okWV+R/iTg==", "c9713cc2-456f-4724-afe7-bbfb499c402f" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 9, 14, 59, 29, 45, DateTimeKind.Utc).AddTicks(9638), new DateTime(2024, 4, 19, 17, 59, 29, 45, DateTimeKind.Local).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 59, 29, 45, DateTimeKind.Utc).AddTicks(9680), new DateTime(2024, 4, 9, 17, 59, 29, 45, DateTimeKind.Local).AddTicks(9681) });
        }
    }
}
