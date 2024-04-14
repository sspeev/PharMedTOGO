using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class AddedRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fac4faf3-e08e-4afd-9b70-6ecbc24dd968", "2931eabf-22a9-4201-b618-0695162053a1", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6e01361-cee6-4e14-80be-97f254f04a6a", "AQAAAAEAACcQAAAAEPIIjxBhUu9urEIp0nISxUTEOIfZIvXBGLrrNaHRtReCHPAMhRthks48QqVZzpq0xw==", "9ce04dcc-f3f9-4f55-8ea9-11f9726b3658" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0c51760-7f92-4509-9d73-4b7229db2be4", "AQAAAAEAACcQAAAAEFB6/hdhJadDUpyZBu1sd1YZ606FzI2kBHYePZNjBfeeYuyXB7LEyyQGvQirLxsgjw==", "1f6b348a-e14c-4315-bdff-eeb30bcdd36b" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 14, 22, 22, 21, 494, DateTimeKind.Utc).AddTicks(1667), new DateTime(2024, 4, 25, 1, 22, 21, 494, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 3, 22, 22, 21, 494, DateTimeKind.Utc).AddTicks(1715), new DateTime(2024, 4, 15, 1, 22, 21, 494, DateTimeKind.Local).AddTicks(1716) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fac4faf3-e08e-4afd-9b70-6ecbc24dd968");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a50c0745-9779-4370-b272-7d40021a7d6f", "AQAAAAEAACcQAAAAEE7P9bKg/1H/GWolV23ktri7g7SJZD89PGlcWeSCiEQMUrxE+iacJaSHng4n4XoZwg==", "5d800491-9c38-4b1e-bc4a-9a39e1958542" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cb2ef43-0e88-406e-82c9-e22b2d7b04d7", "AQAAAAEAACcQAAAAEBUYqnJOy1XFcXZX89r+wz71qPxM3fVHdpyDI2qZcfWjys4aKwGxuhFE0794sGMaAA==", "e8131c93-8460-45f6-802f-d57ab1a0e49e" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 14, 14, 18, 21, 145, DateTimeKind.Utc).AddTicks(2107), new DateTime(2024, 4, 24, 17, 18, 21, 145, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 3, 14, 18, 21, 145, DateTimeKind.Utc).AddTicks(2280), new DateTime(2024, 4, 14, 17, 18, 21, 145, DateTimeKind.Local).AddTicks(2281) });
        }
    }
}
