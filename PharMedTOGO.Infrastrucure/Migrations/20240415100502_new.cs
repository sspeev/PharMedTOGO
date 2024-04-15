using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "90d6293e-bfed-48c5-a55b-9a2aeae2700d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cd8468a-8d9b-4711-a7e4-5e9efa450101", "AQAAAAEAACcQAAAAEHGCCdsLYonXIf2hwEvAJ4J/FC0Xwe6l+CwIX0JlcX6u7T3ql0S7/VXZEPuj14zSTQ==", "a546c176-5466-4e31-a190-8588d4d8648e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9009329a-972e-44a8-bf28-b29149559027", "AQAAAAEAACcQAAAAEChEmZ+/gj+bTbaXKY7Bn5t6cl1Oa8BV2eyVXlMl4tm/f3wIy5D6TFtflGRlV9MH5w==", "b6606573-4f68-45e7-aa0c-baf7402563f4" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 5, 1, 489, DateTimeKind.Local).AddTicks(6057), new DateTime(2024, 4, 25, 13, 5, 1, 489, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 10, 5, 1, 489, DateTimeKind.Utc).AddTicks(6106), new DateTime(2024, 4, 15, 13, 5, 1, 489, DateTimeKind.Local).AddTicks(6107) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "eceb9fac-55be-4b66-9e0f-6007fe48186a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b7600ea-9bc4-487a-a8cd-10954553d53f", "AQAAAAEAACcQAAAAEPZmP+zUS5vbzpgivWT1ZDzUqR2iQohCpsszDYoL4jiCqfvj6bkQ5FatQI4+wKHOSw==", "d81fe9a4-466b-4cf1-a369-ca9293e33e89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "432e89af-d033-4468-8552-0e402bfa9c88", "AQAAAAEAACcQAAAAEHhdzMbrVX9ORQHFAViY175qxEIPEuHM//uF8sj+gprOf1De0kuIkvU9nF3eqUMXng==", "a50ae676-a379-4f56-a219-ba06359809a6" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 50, 12, 141, DateTimeKind.Local).AddTicks(5907), new DateTime(2024, 4, 25, 12, 50, 12, 141, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 9, 50, 12, 141, DateTimeKind.Utc).AddTicks(5956), new DateTime(2024, 4, 15, 12, 50, 12, 141, DateTimeKind.Local).AddTicks(5956) });
        }
    }
}
