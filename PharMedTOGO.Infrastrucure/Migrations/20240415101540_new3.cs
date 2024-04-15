using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class new3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "69aac090-dcc8-4e1a-ada5-6ea5691a862f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d76ee5cb-d2b2-4e0d-8544-5634c1566293", "AQAAAAEAACcQAAAAEKKun+feXig0l8WDo3FqomYATGjGsyEbOoBdlrnWm7VUYLuBEeeFfAoDg8SiWDMP7Q==", "57ff3e94-8e0b-4ec5-9468-b5083f468b5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e19dbc6-c5d1-421e-a0e7-ff442884b06a", "AQAAAAEAACcQAAAAEHOQkBoExeS1ursOg9wO9u/6tVpO6OH3TBPzaGhCmX8wmdGFtSv5UIEc+d5cBgw+0w==", "f32c3c74-0ac5-4438-aa54-c6d6945315d8" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 15, 39, 717, DateTimeKind.Local).AddTicks(9953), new DateTime(2024, 4, 25, 13, 15, 39, 717, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 10, 15, 39, 718, DateTimeKind.Utc).AddTicks(7), new DateTime(2024, 4, 15, 13, 15, 39, 718, DateTimeKind.Local).AddTicks(8) });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "Discount", "EndDate", "IsEnded", "StartDate" },
                values: new object[,]
                {
                    { 1, 50m, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, 30m, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Local) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2);

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
    }
}
