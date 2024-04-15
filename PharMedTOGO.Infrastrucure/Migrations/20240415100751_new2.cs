using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class new2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "715f4ea9-48ce-4363-83e4-aa233179de45");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ecdd5b3f-0885-45fd-bd2f-1e5c6e8bbee1", "AQAAAAEAACcQAAAAEGr+niPhVk1E5CDb7AYTsBDbd3wxKuZIgkDCxzSP40he0W1Ugu8HZpqYD7bw/rQNDg==", "179b9b83-0e3e-4a1f-9bf4-315873071808" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7924d18-544b-46f4-914d-504daacda1d1", "AQAAAAEAACcQAAAAEPNDMN6pBBIWBJ7UDRd4uqeDwo02HnkD4jmrvMqYBFNlqDJnr6EvSacJxZ9xiNcXpg==", "f025078b-6eed-44c0-a9cc-d048a3078b07" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 7, 50, 811, DateTimeKind.Local).AddTicks(832), new DateTime(2024, 4, 25, 13, 7, 50, 811, DateTimeKind.Local).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 10, 7, 50, 811, DateTimeKind.Utc).AddTicks(883), new DateTime(2024, 4, 15, 13, 7, 50, 811, DateTimeKind.Local).AddTicks(884) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
